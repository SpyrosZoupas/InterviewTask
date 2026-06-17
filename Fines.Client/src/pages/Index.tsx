import {
  Button,
  Collapse,
  Flex,
  Group,
  Loader,
  NativeSelect,
  Paper,
  Table,
  Text,
} from "@mantine/core";
import { useDisclosure } from "@mantine/hooks";
import { useFines } from "../hooks/useFines";
import { FineTypeLabels } from "../enum/fineType";
import {
  IconAlertTriangleFilled,
  IconChevronDown,
  IconChevronUp,
  IconFilterFilled,
} from "@tabler/icons-react";
import { useState } from "react";

export default function Index() {
  const [opened, { toggle }] = useDisclosure(false);
  const { fines, loading, error } = useFines();

  const [selectedFineType, setSelectedFineType] = useState("");

  const fineTypes = [
    { value: "", label: "Any" },
    ...Object.entries(FineTypeLabels).map(([key, label]) => ({
      value: key,
      label,
    })),
  ];

  const rows = fines.map((fine) => (
    <Table.Tr key={fine.id}>
      <Table.Td>{fine.fineNo}</Table.Td>
      <Table.Td>{fine.fineDate.toLocaleDateString()}</Table.Td>
      <Table.Td>{FineTypeLabels[fine.fineType]}</Table.Td>
      <Table.Td>{fine.vehicleRegNo}</Table.Td>
      <Table.Td>{fine.vehicleDriverName}</Table.Td>
    </Table.Tr>
  ));

  return (
    <main>
      <h2>Index</h2>

      <Button onClick={toggle} mb="md" variant="subtle">
        <Group gap="xs">
          <IconFilterFilled size={16} />
          <Text>Filters</Text>
          {opened ? <IconChevronUp size={16} /> : <IconChevronDown size={16} />}
        </Group>
      </Button>
      <Collapse in={opened}>
        <Paper shadow="xs" px="xl" py="md" mb="md">
          <Flex direction="row" gap="md">
            <NativeSelect
              flex="0 1 20rem"
              data={fineTypes}
              value={selectedFineType}
              onChange={(event) =>
                setSelectedFineType(event.currentTarget.value)
              }
              label="Fine Type"
            />
          </Flex>
        </Paper>
      </Collapse>

      <Paper shadow="xs" p="xl">
        {loading ? (
          <Loader />
        ) : error ? (
          <Group gap="xs" c="red">
            <IconAlertTriangleFilled size={16} />
            <Text>{error}</Text>
          </Group>
        ) : (
          <Table>
            <Table.Thead>
              <Table.Tr>
                <Table.Th>Fine Number</Table.Th>
                <Table.Th>Fine Date</Table.Th>
                <Table.Th>Fine Type</Table.Th>
                <Table.Th>Vehicle Registration</Table.Th>
                <Table.Th>Vehicle Driver Name</Table.Th>
              </Table.Tr>
            </Table.Thead>
            <Table.Tbody>{rows}</Table.Tbody>
          </Table>
        )}
      </Paper>
    </main>
  );
}

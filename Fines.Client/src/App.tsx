import "@mantine/core/styles.css";
import { AppShell, Flex, Image, useMantineTheme } from "@mantine/core";
import Index from "./pages/Index";

export default function App() {
  const theme = useMantineTheme();

  return (
    <AppShell
      padding="md"
      header={{ height: 60 }}
      style={{ backgroundColor: theme.other.appBackground }}>
      <AppShell.Header>
        <Flex align="center" gap="md" h="100%" px="md">
          <Image src="/logo.svg" alt="Logo" w={40} h={40} fit="contain" />
          <h1 style={{ margin: 0 }}>Fines</h1>
        </Flex>
      </AppShell.Header>
      <AppShell.Main>
        <Index />
      </AppShell.Main>
    </AppShell>
  );
}

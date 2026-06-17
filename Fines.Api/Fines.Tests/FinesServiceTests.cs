using Fines.Core.Dtos;
using Fines.Core.Enums;
using Fines.Data.Models;
using Fines.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace Fines.Tests
{
    public class FinesServiceTests
    {
        private readonly Mock<IFinesRepository> _mockRepository;
        private readonly Mock<ILogger<FinesService>> _mockLogger;
        private readonly FinesService _service;

        public FinesServiceTests()
        {
            _mockRepository = new Mock<IFinesRepository>();
            _mockLogger = new Mock<ILogger<FinesService>>();
            _service = new FinesService(_mockRepository.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task GetFinesAsync_WhenCalled_ReturnsAllFines()
        {
            // Arrange
            var finesEntities = GetSampleFinesEntities();
            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ReturnsAsync(finesEntities);

            // Act
            var result = await _service.GetFinesAsync();

            // Assert
            var finesList = result.ToList();
            Assert.NotNull(finesList);
            Assert.Equal(3, finesList.Count);
        }

        [Fact]
        public async Task GetFinesAsync_WhenCalled_CallsRepositoryOnce()
        {
            // Arrange
            var finesEntities = GetSampleFinesEntities();
            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ReturnsAsync(finesEntities);

            // Act
            await _service.GetFinesAsync();

            // Assert
            _mockRepository.Verify(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()), Times.Once);
        }

        [Fact]
        public async Task GetFinesAsync_WhenCalled_MapsEntitiesToResponses()
        {
            // Arrange
            var vehicle = new VehicleEntity
            {
                Id = 1,
                RegistrationNumber = "ABC123",
                Make = "Ford",
                Model = "Focus",
                Color = "Blue",
                Year = 2020
            };

            var customer = new CustomerEntity
            {
                Id = 1,
                CompanyName = "Test Company",
                Email = "test@example.com",
                PhoneNumber = "1234567890",
                Address = "Test Address",
                City = "Test City",
                PostCode = "12345"
            };

            var finesEntities = new List<FinesEntity>
            {
                new FinesEntity
                {
                    Id = 1,
                    FineNo = "FN-001",
                    FineDate = new DateTime(2024, 1, 15),
                    FineType = FineType.Speeding,
                    VehicleId = 1,
                    Vehicle = vehicle,
                    VehicleDriverName = "John Doe",
                    CustomerId = 1,
                    Customer = customer
                }
            };
            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ReturnsAsync(finesEntities);

            // Act
            var result = await _service.GetFinesAsync();

            // Assert
            var fine = result.First();
            Assert.Equal(1, fine.Id);
            Assert.Equal("FN-001", fine.FineNo);
            Assert.Equal(new DateTime(2024, 1, 15), fine.FineDate);
            Assert.Equal(FineType.Speeding, fine.FineType);
            Assert.Equal("ABC123", fine.VehicleRegNo);
            Assert.Equal("John Doe", fine.VehicleDriverName);
            Assert.Equal("Test Company", fine.CustomerCompanyName);
        }

        [Fact]
        public async Task GetFinesAsync_WhenNoFines_ReturnsEmptyCollection()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ReturnsAsync(new List<FinesEntity>());

            // Act
            var result = await _service.GetFinesAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetFinesAsync_MapsAllFineTypes_Correctly()
        {
            // Arrange
            var customer = new CustomerEntity { Id = 1, CompanyName = "Test Company" };
            var finesEntities = new List<FinesEntity>
            {
                new FinesEntity { Id = 1, FineNo = "FN-001", FineDate = DateTime.Now, FineType = FineType.Speeding, VehicleId = 1, Vehicle = new VehicleEntity { Id = 1, RegistrationNumber = "REG1" }, VehicleDriverName = "Driver1", CustomerId = 1, Customer = customer },
                new FinesEntity { Id = 2, FineNo = "FN-002", FineDate = DateTime.Now, FineType = FineType.Parking, VehicleId = 2, Vehicle = new VehicleEntity { Id = 2, RegistrationNumber = "REG2" }, VehicleDriverName = "Driver2", CustomerId = 1, Customer = customer },
                new FinesEntity { Id = 3, FineNo = "FN-003", FineDate = DateTime.Now, FineType = FineType.RedLightViolation, VehicleId = 3, Vehicle = new VehicleEntity { Id = 3, RegistrationNumber = "REG3" }, VehicleDriverName = "Driver3", CustomerId = 1, Customer = customer },
                new FinesEntity { Id = 4, FineNo = "FN-004", FineDate = DateTime.Now, FineType = FineType.NoInsurance, VehicleId = 4, Vehicle = new VehicleEntity { Id = 4, RegistrationNumber = "REG4" }, VehicleDriverName = "Driver4", CustomerId = 1, Customer = customer },
                new FinesEntity { Id = 5, FineNo = "FN-005", FineDate = DateTime.Now, FineType = FineType.SeatBeltViolation, VehicleId = 5, Vehicle = new VehicleEntity { Id = 5, RegistrationNumber = "REG5" }, VehicleDriverName = "Driver5", CustomerId = 1, Customer = customer }
            };
            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ReturnsAsync(finesEntities);

            // Act
            var result = await _service.GetFinesAsync();

            // Assert
            var finesList = result.ToList();
            Assert.Equal(FineType.Speeding, finesList[0].FineType);
            Assert.Equal(FineType.Parking, finesList[1].FineType);
            Assert.Equal(FineType.RedLightViolation, finesList[2].FineType);
            Assert.Equal(FineType.NoInsurance, finesList[3].FineType);
            Assert.Equal(FineType.SeatBeltViolation, finesList[4].FineType);
        }

        [Fact]
        public async Task GetFinesAsync_WhenRepositoryThrowsException_PropagatesException()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ThrowsAsync(new Exception("Database error"));

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => _service.GetFinesAsync());
        }

        private static List<FinesEntity> GetSampleFinesEntities()
        {
            var customer = new CustomerEntity { Id = 1, CompanyName = "Test Company", Email = "test@example.com", PhoneNumber = "1234567890", Address = "Test Address", City = "Test City", PostCode = "12345" };

            return new List<FinesEntity>
            {
                new FinesEntity
                {
                    Id = 1,
                    FineNo = "FN-001",
                    FineDate = new DateTime(2024, 1, 15),
                    FineType = FineType.Speeding,
                    VehicleId = 1,
                    Vehicle = new VehicleEntity { Id = 1, RegistrationNumber = "ABC123", Make = "Ford", Model = "Focus", Color = "Blue", Year = 2020 },
                    VehicleDriverName = "John Doe",
                    CustomerId = 1,
                    Customer = customer
                },
                new FinesEntity
                {
                    Id = 2,
                    FineNo = "FN-002",
                    FineDate = new DateTime(2024, 1, 20),
                    FineType = FineType.Parking,
                    VehicleId = 2,
                    Vehicle = new VehicleEntity { Id = 2, RegistrationNumber = "XYZ789", Make = "Volkswagen", Model = "Golf", Color = "Silver", Year = 2021 },
                    VehicleDriverName = "Jane Smith",
                    CustomerId = 1,
                    Customer = customer
                },
                new FinesEntity
                {
                    Id = 3,
                    FineNo = "FN-003",
                    FineDate = new DateTime(2024, 2, 5),
                    FineType = FineType.RedLightViolation,
                    VehicleId = 3,
                    Vehicle = new VehicleEntity { Id = 3, RegistrationNumber = "DEF456", Make = "BMW", Model = "3 Series", Color = "Black", Year = 2022 },
                    VehicleDriverName = "Bob Johnson",
                    CustomerId = 1,
                    Customer = customer
                }
            };
        }

        [Fact]
        public async Task GetFinesAsync_WithFilters_MapsResultsCorrectly()
        {
            // Arrange
            var vehicle = new VehicleEntity
            {
                Id = 1,
                RegistrationNumber = "ABC123",
                Make = "Ford",
                Model = "Focus",
                Color = "Blue",
                Year = 2020
            };

            var customer = new CustomerEntity
            {
                Id = 1,
                CompanyName = "Premium Insurance Co",
                Email = "test@example.com",
                PhoneNumber = "1234567890",
                Address = "Test Address",
                City = "Test City",
                PostCode = "12345"
            };

            var filteredFines = new List<FinesEntity>
            {
                new FinesEntity
                {
                    Id = 1,
                    FineNo = "FN-001",
                    FineDate = new DateTime(2024, 1, 15),
                    FineType = FineType.Speeding,
                    VehicleId = 1,
                    Vehicle = vehicle,
                    VehicleDriverName = "John Doe",
                    CustomerId = 1,
                    Customer = customer
                }
            };

            var filters = new FineFiltersRequest { FineType = "Speeding" };

            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ReturnsAsync(filteredFines);

            // Act
            var result = await _service.GetFinesAsync(filters);

            // Assert
            var resultList = result.ToList();
            Assert.Single(resultList);

            var mappedFine = resultList[0];
            Assert.Equal(1, mappedFine.Id);
            Assert.Equal("FN-001", mappedFine.FineNo);
            Assert.Equal(FineType.Speeding, mappedFine.FineType);
            Assert.Equal("ABC123", mappedFine.VehicleRegNo);
            Assert.Equal("John Doe", mappedFine.VehicleDriverName);
            Assert.Equal("Premium Insurance Co", mappedFine.CustomerCompanyName);
        }

        [Fact]
        public async Task GetFinesAsync_WithFilteredListEmpty_ReturnsEmptyCollection()
        {
            // Arrange
            var filters = new FineFiltersRequest { VehicleRegNo = "NONEXISTENT" };

            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ReturnsAsync(new List<FinesEntity>());

            // Act
            var result = await _service.GetFinesAsync(filters);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetFinesAsync_WithFineDataContainsNullableProperties_SuccessfullyMaps()
        {
            // Arrange
            var finesWithNullData = new List<FinesEntity>
            {
                new FinesEntity
                {
                    Id = 1,
                    FineNo = "FN-001",
                    FineDate = DateTime.Now,
                    FineType = FineType.Speeding,
                    VehicleId = 1,
                    Vehicle = new VehicleEntity { Id = 1, RegistrationNumber = "ABC123" },
                    VehicleDriverName = "",
                    CustomerId = 1,
                    Customer = new CustomerEntity { Id = 1, CompanyName = "" }
                }
            };

            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ReturnsAsync(finesWithNullData);

            // Act
            var result = await _service.GetFinesAsync();

            // Assert
            var resultList = result.ToList();
            Assert.Single(resultList);
            Assert.Equal("", resultList[0].VehicleDriverName);
            Assert.Equal("", resultList[0].CustomerCompanyName);
        }

        [Fact]
        public async Task GetFinesAsync_CalledMultipleTimes_ReturnsConsistentResults()
        {
            // Arrange
            var finesEntities = GetSampleFinesEntities();
            _mockRepository.Setup(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()))
                .ReturnsAsync(finesEntities);

            // Act
            var result1 = await _service.GetFinesAsync();
            var result2 = await _service.GetFinesAsync();
            var result3 = await _service.GetFinesAsync();

            // Assert
            Assert.Equal(result1.Count(), result2.Count());
            Assert.Equal(result2.Count(), result3.Count());
            _mockRepository.Verify(repo => repo.GetAllFinesAsync(It.IsAny<FineFiltersRequest?>()), Times.Exactly(3));
        }
    }
}
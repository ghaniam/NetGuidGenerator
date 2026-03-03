namespace GuidGenerator.Tests;

public class GuidGeneratorServiceTests
{
    private readonly GuidGeneratorService _guidGenerator;

    public GuidGeneratorServiceTests()
    {
        _guidGenerator = new GuidGeneratorService();
    }

    [Fact]
    public void GenerateGuids_WithValidCount_ReturnsCorrectNumberOfGuids()
    {
        // Arrange
        int count = 5;

        // Act
        var result = _guidGenerator.GenerateGuids(count);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(count, result.Count);
    }

    [Fact]
    public void GenerateGuids_WithCountOfOne_ReturnsSingleGuid()
    {
        // Arrange
        int count = 1;

        // Act
        var result = _guidGenerator.GenerateGuids(count);

        // Assert
        Assert.NotNull(result);
        Assert.Single(result);
        Assert.NotEqual(Guid.Empty, result[0]);
    }

    [Fact]
    public void GenerateGuids_GeneratesUniqueGuids()
    {
        // Arrange
        int count = 100;

        // Act
        var result = _guidGenerator.GenerateGuids(count);

        // Assert
        var distinctGuids = result.Distinct().ToList();
        Assert.Equal(count, distinctGuids.Count);
    }

    [Fact]
    public void GenerateGuids_WithZeroCount_ThrowsArgumentException()
    {
        // Arrange
        int count = 0;

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => _guidGenerator.GenerateGuids(count));
        Assert.Equal("count", exception.ParamName);
        Assert.Contains("Count must be greater than zero", exception.Message);
    }

    [Fact]
    public void GenerateGuids_WithNegativeCount_ThrowsArgumentException()
    {
        // Arrange
        int count = -5;

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => _guidGenerator.GenerateGuids(count));
        Assert.Equal("count", exception.ParamName);
        Assert.Contains("Count must be greater than zero", exception.Message);
    }

    [Fact]
    public void GenerateGuids_GeneratesValidGuids()
    {
        // Arrange
        int count = 10;

        // Act
        var result = _guidGenerator.GenerateGuids(count);

        // Assert
        foreach (var guid in result)
        {
            Assert.NotEqual(Guid.Empty, guid);
        }
    }

    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(100)]
    [InlineData(1000)]
    public void GenerateGuids_WithVariousCounts_ReturnsCorrectNumberOfGuids(int count)
    {
        // Act
        var result = _guidGenerator.GenerateGuids(count);

        // Assert
        Assert.Equal(count, result.Count);
    }
}

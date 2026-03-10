namespace GuidGenerator.Core;

public class GuidGeneratorService : IGuidGeneratorService
{
    /// <summary>
    /// Generates a specified number of GUIDs.
    /// </summary>
    /// <param name="count">The number of GUIDs to generate.</param>
    /// <returns>A list of generated GUIDs.</returns>
    /// <exception cref="ArgumentException">Thrown when count is less than or equal to zero.</exception>
    public List<Guid> GenerateGuids(int count)
    {
        if (count <= 0)
        {
            throw new ArgumentException("Count must be greater than zero.", nameof(count));
        }

        var guids = new List<Guid>(count);
        for (int i = 0; i < count; i++)
        {
            guids.Add(Guid.NewGuid());
        }

        return guids;
    }
}

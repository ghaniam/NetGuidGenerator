namespace GuidGenerator.Core;
public interface IGuidGeneratorService
{
    /// <summary>
    /// Generates a specified number of GUIDs.
    /// </summary>
    /// <param name="count">The number of GUIDs to generate.</param>
    /// <returns>A list of generated GUIDs.</returns>
    List<Guid> GenerateGuids(int count);
}
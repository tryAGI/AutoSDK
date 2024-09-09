namespace AutoSDK.Models;

/// <summary>
/// 
/// </summary>
/// <param name="Name"></param>
/// <param name="Text"></param>
public readonly record struct FileWithName(
    string Name,
    string Text)
{
    /// <summary>
    /// 
    /// </summary>
    public static FileWithName Empty => new(
        Name: string.Empty,
        Text: string.Empty);

    /// <summary>
    /// 
    /// </summary>
    public bool IsEmpty => string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Text);
}

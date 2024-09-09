using H.Generators.Extensions;

namespace AutoSDK.SourceGenerators;

public static class TypeExtensions
{
    public static FileWithName AsFileWithName(this AutoSDK.Models.FileWithName value)
    {
        return new FileWithName(value.Name, value.Text);
    }
}
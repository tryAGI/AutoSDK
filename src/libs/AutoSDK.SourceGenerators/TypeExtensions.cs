using AutoSDK.Models;

namespace AutoSDK.SourceGenerators;

public static class TypeExtensions
{
    public static FileWithName AsFileWithName(this FileWithName value)
    {
        return new FileWithName(value.Name, value.Text);
    }
}
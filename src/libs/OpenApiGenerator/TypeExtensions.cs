using H.Generators.Extensions;

namespace OpenApiGenerator;

public static class TypeExtensions
{
    public static FileWithName AsFileWithName(this OpenApiGenerator.Core.Models.FileWithName value)
    {
        return new FileWithName(value.Name, value.Text);
    }
}
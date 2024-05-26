using System.Globalization;
using System.Linq;

namespace OpenApiGenerator.Helpers.JsonEnumConverter;

internal static class StringExtensions
{
    public static string ToSnakeCase(string @string)
        => string.IsNullOrEmpty(@string)
            ? @string
            : string.Concat(
                @string.Select((x, i) => i > 0 && char.IsUpper(x)
                    ? $"_{x}"
                    : x.ToString())).ToLower(CultureInfo.InvariantCulture);
}
//HintName: G.Models.TemplateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: tool
    /// </summary>
    public enum TemplateType
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateType value)
        {
            return value switch
            {
                TemplateType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => TemplateType.Tool,
                _ => null,
            };
        }
    }
}
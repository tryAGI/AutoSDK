//HintName: G.Models.UpdateToolTemplateDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: tool
    /// </summary>
    public enum UpdateToolTemplateDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateToolTemplateDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateToolTemplateDTOType value)
        {
            return value switch
            {
                UpdateToolTemplateDTOType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateToolTemplateDTOType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => UpdateToolTemplateDTOType.Tool,
                _ => null,
            };
        }
    }
}
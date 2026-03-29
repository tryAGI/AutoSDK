//HintName: G.Models.PromptVersionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionType
    {
        /// <summary>
        /// 
        /// </summary>
        Jinja2,
        /// <summary>
        /// 
        /// </summary>
        Mustache,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionType value)
        {
            return value switch
            {
                PromptVersionType.Jinja2 => "jinja2",
                PromptVersionType.Mustache => "mustache",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionType? ToEnum(string value)
        {
            return value switch
            {
                "jinja2" => PromptVersionType.Jinja2,
                "mustache" => PromptVersionType.Mustache,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.PromptVersionPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionPublicType
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
    public static class PromptVersionPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionPublicType value)
        {
            return value switch
            {
                PromptVersionPublicType.Jinja2 => "jinja2",
                PromptVersionPublicType.Mustache => "mustache",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionPublicType? ToEnum(string value)
        {
            return value switch
            {
                "jinja2" => PromptVersionPublicType.Jinja2,
                "mustache" => PromptVersionPublicType.Mustache,
                _ => null,
            };
        }
    }
}
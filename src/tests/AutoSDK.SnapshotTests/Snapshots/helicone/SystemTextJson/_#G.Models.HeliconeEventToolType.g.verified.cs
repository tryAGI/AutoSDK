//HintName: G.Models.HeliconeEventToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HeliconeEventToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeliconeEventToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeliconeEventToolType value)
        {
            return value switch
            {
                HeliconeEventToolType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeliconeEventToolType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => HeliconeEventToolType.Tool,
                _ => null,
            };
        }
    }
}
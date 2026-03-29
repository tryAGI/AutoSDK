//HintName: G.Models.PromptMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptMode
    {
        /// <summary>
        /// 
        /// </summary>
        Prefix,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptMode value)
        {
            return value switch
            {
                PromptMode.Prefix => "prefix",
                PromptMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptMode? ToEnum(string value)
        {
            return value switch
            {
                "prefix" => PromptMode.Prefix,
                "standard" => PromptMode.Standard,
                _ => null,
            };
        }
    }
}
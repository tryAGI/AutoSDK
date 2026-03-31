//HintName: G.Models.ToolChoiceStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool choice strategy for LLM function calling
    /// </summary>
    public enum ToolChoiceStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceStrategy value)
        {
            return value switch
            {
                ToolChoiceStrategy.Auto => "auto",
                ToolChoiceStrategy.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceStrategy? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolChoiceStrategy.Auto,
                "required" => ToolChoiceStrategy.Required,
                _ => null,
            };
        }
    }
}
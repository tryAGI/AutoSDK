//HintName: G.Models.Prompt2025VersionPromptBodyToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Prompt2025VersionPromptBodyToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Prompt2025VersionPromptBodyToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Prompt2025VersionPromptBodyToolType value)
        {
            return value switch
            {
                Prompt2025VersionPromptBodyToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Prompt2025VersionPromptBodyToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => Prompt2025VersionPromptBodyToolType.Function,
                _ => null,
            };
        }
    }
}
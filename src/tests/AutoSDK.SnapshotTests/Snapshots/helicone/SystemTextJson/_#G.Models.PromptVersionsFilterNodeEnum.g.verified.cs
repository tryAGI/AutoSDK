//HintName: G.Models.PromptVersionsFilterNodeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionsFilterNodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionsFilterNodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionsFilterNodeEnum value)
        {
            return value switch
            {
                PromptVersionsFilterNodeEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionsFilterNodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => PromptVersionsFilterNodeEnum.All,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.PromptsFilterNodeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptsFilterNodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptsFilterNodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptsFilterNodeEnum value)
        {
            return value switch
            {
                PromptsFilterNodeEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptsFilterNodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => PromptsFilterNodeEnum.All,
                _ => null,
            };
        }
    }
}
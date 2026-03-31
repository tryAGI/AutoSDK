//HintName: G.Models.ResearchOperationDtoClassVariant2SearchType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchOperationDtoClassVariant2SearchType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Deep,
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Neural,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchOperationDtoClassVariant2SearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchOperationDtoClassVariant2SearchType value)
        {
            return value switch
            {
                ResearchOperationDtoClassVariant2SearchType.Auto => "auto",
                ResearchOperationDtoClassVariant2SearchType.Deep => "deep",
                ResearchOperationDtoClassVariant2SearchType.Fast => "fast",
                ResearchOperationDtoClassVariant2SearchType.Neural => "neural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchOperationDtoClassVariant2SearchType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResearchOperationDtoClassVariant2SearchType.Auto,
                "deep" => ResearchOperationDtoClassVariant2SearchType.Deep,
                "fast" => ResearchOperationDtoClassVariant2SearchType.Fast,
                "neural" => ResearchOperationDtoClassVariant2SearchType.Neural,
                _ => null,
            };
        }
    }
}
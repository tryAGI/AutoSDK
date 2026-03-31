//HintName: G.Models.ResearchOperationDtoClassVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchOperationDtoClassVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Crawl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchOperationDtoClassVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchOperationDtoClassVariant3Type value)
        {
            return value switch
            {
                ResearchOperationDtoClassVariant3Type.Crawl => "crawl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchOperationDtoClassVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => ResearchOperationDtoClassVariant3Type.Crawl,
                _ => null,
            };
        }
    }
}
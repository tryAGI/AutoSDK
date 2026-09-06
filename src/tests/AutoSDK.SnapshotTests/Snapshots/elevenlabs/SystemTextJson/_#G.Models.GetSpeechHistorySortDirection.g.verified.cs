//HintName: G.Models.GetSpeechHistorySortDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpeechHistorySortDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpeechHistorySortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpeechHistorySortDirection value)
        {
            return value switch
            {
                GetSpeechHistorySortDirection.Asc => "asc",
                GetSpeechHistorySortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpeechHistorySortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSpeechHistorySortDirection.Asc,
                "desc" => GetSpeechHistorySortDirection.Desc,
                _ => null,
            };
        }
    }
}
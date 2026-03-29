//HintName: G.Models.SessionNameQueryParamsPSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionNameQueryParamsPSize
    {
        /// <summary>
        /// 
        /// </summary>
        P50,
        /// <summary>
        /// 
        /// </summary>
        P75,
        /// <summary>
        /// 
        /// </summary>
        P95,
        /// <summary>
        /// 
        /// </summary>
        P99,
        /// <summary>
        /// 
        /// </summary>
        P999,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionNameQueryParamsPSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionNameQueryParamsPSize value)
        {
            return value switch
            {
                SessionNameQueryParamsPSize.P50 => "p50",
                SessionNameQueryParamsPSize.P75 => "p75",
                SessionNameQueryParamsPSize.P95 => "p95",
                SessionNameQueryParamsPSize.P99 => "p99",
                SessionNameQueryParamsPSize.P999 => "p99.9",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionNameQueryParamsPSize? ToEnum(string value)
        {
            return value switch
            {
                "p50" => SessionNameQueryParamsPSize.P50,
                "p75" => SessionNameQueryParamsPSize.P75,
                "p95" => SessionNameQueryParamsPSize.P95,
                "p99" => SessionNameQueryParamsPSize.P99,
                "p99.9" => SessionNameQueryParamsPSize.P999,
                _ => null,
            };
        }
    }
}
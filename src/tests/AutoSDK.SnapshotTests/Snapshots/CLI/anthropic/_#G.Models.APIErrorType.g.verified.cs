//HintName: G.Models.APIErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: api_error
    /// </summary>
    public enum APIErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIErrorType value)
        {
            return value switch
            {
                APIErrorType.ApiError => "api_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIErrorType? ToEnum(string value)
        {
            return value switch
            {
                "api_error" => APIErrorType.ApiError,
                _ => null,
            };
        }
    }
}
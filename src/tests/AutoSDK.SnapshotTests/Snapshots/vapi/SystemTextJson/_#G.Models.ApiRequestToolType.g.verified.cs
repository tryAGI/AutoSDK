//HintName: G.Models.ApiRequestToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "apiRequest" for API request tool.
    /// </summary>
    public enum ApiRequestToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiRequestToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiRequestToolType value)
        {
            return value switch
            {
                ApiRequestToolType.ApiRequest => "apiRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiRequestToolType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => ApiRequestToolType.ApiRequest,
                _ => null,
            };
        }
    }
}
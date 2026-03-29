//HintName: G.Models.ApiKeyObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: api-key
    /// </summary>
    public enum ApiKeyObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyObjectObject value)
        {
            return value switch
            {
                ApiKeyObjectObject.ApiKey => "api-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => ApiKeyObjectObject.ApiKey,
                _ => null,
            };
        }
    }
}
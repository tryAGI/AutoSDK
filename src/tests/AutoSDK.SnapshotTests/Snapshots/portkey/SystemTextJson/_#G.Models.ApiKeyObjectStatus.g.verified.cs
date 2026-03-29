//HintName: G.Models.ApiKeyObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: active
    /// </summary>
    public enum ApiKeyObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Exhausted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyObjectStatus value)
        {
            return value switch
            {
                ApiKeyObjectStatus.Active => "active",
                ApiKeyObjectStatus.Exhausted => "exhausted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ApiKeyObjectStatus.Active,
                "exhausted" => ApiKeyObjectStatus.Exhausted,
                _ => null,
            };
        }
    }
}
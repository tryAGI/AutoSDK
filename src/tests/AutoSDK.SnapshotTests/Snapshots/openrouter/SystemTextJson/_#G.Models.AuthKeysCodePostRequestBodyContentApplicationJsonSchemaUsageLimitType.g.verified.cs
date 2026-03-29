//HintName: G.Models.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional credit limit reset interval. When set, the credit limit resets on this interval.
    /// </summary>
    public enum AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType value)
        {
            return value switch
            {
                AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType.Daily => "daily",
                AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType.Monthly => "monthly",
                AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType? ToEnum(string value)
        {
            return value switch
            {
                "daily" => AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType.Daily,
                "monthly" => AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType.Monthly,
                "weekly" => AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType.Weekly,
                _ => null,
            };
        }
    }
}
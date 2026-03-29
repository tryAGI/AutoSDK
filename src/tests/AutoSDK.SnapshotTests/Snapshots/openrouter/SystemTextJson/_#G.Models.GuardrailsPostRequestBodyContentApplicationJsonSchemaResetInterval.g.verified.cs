//HintName: G.Models.GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Interval at which the limit resets (daily, weekly, monthly)
    /// </summary>
    public enum GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval
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
    public static class GuardrailsPostRequestBodyContentApplicationJsonSchemaResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval value)
        {
            return value switch
            {
                GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval.Daily => "daily",
                GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval.Monthly => "monthly",
                GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval.Daily,
                "monthly" => GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval.Monthly,
                "weekly" => GuardrailsPostRequestBodyContentApplicationJsonSchemaResetInterval.Weekly,
                _ => null,
            };
        }
    }
}
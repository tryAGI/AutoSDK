//HintName: G.Models.GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Interval at which the limit resets (daily, weekly, monthly)
    /// </summary>
    public enum GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval
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
    public static class GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval value)
        {
            return value switch
            {
                GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval.Daily => "daily",
                GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval.Monthly => "monthly",
                GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval.Daily,
                "monthly" => GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval.Monthly,
                "weekly" => GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetInterval.Weekly,
                _ => null,
            };
        }
    }
}
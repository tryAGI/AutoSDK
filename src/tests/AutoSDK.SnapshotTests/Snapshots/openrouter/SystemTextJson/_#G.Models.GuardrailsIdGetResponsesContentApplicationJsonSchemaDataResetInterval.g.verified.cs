//HintName: G.Models.GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Interval at which the limit resets (daily, weekly, monthly)
    /// </summary>
    public enum GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval
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
    public static class GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval value)
        {
            return value switch
            {
                GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval.Daily => "daily",
                GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval.Monthly => "monthly",
                GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval.Daily,
                "monthly" => GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval.Monthly,
                "weekly" => GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetInterval.Weekly,
                _ => null,
            };
        }
    }
}
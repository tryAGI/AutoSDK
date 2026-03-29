//HintName: G.Models.GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Interval at which the limit resets (daily, weekly, monthly)
    /// </summary>
    public enum GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval
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
    public static class GuardrailsPostResponsesContentApplicationJsonSchemaDataResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval value)
        {
            return value switch
            {
                GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval.Daily => "daily",
                GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval.Monthly => "monthly",
                GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval.Daily,
                "monthly" => GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval.Monthly,
                "weekly" => GuardrailsPostResponsesContentApplicationJsonSchemaDataResetInterval.Weekly,
                _ => null,
            };
        }
    }
}
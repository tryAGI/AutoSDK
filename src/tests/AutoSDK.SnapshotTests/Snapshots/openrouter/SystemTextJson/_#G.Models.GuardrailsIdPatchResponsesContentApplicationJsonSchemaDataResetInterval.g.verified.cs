//HintName: G.Models.GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Interval at which the limit resets (daily, weekly, monthly)
    /// </summary>
    public enum GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval
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
    public static class GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval value)
        {
            return value switch
            {
                GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval.Daily => "daily",
                GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval.Monthly => "monthly",
                GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval.Daily,
                "monthly" => GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval.Monthly,
                "weekly" => GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetInterval.Weekly,
                _ => null,
            };
        }
    }
}
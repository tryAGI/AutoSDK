//HintName: G.Models.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Interval at which the limit resets (daily, weekly, monthly)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="daily")]
        Daily,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monthly")]
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="weekly")]
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval value)
        {
            return value switch
            {
                GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval.Daily => "daily",
                GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval.Monthly => "monthly",
                GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval? ToEnum(string value)
        {
            return value switch
            {
                "daily" => GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval.Daily,
                "monthly" => GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval.Monthly,
                "weekly" => GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval.Weekly,
                _ => null,
            };
        }
    }
}
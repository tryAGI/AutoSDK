//HintName: G.Models.RunRulesPagerdutyAlertSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for alert types.
    /// </summary>
    public enum RunRulesPagerdutyAlertSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        Pagerduty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunRulesPagerdutyAlertSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunRulesPagerdutyAlertSchemaType value)
        {
            return value switch
            {
                RunRulesPagerdutyAlertSchemaType.Pagerduty => "pagerduty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunRulesPagerdutyAlertSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => RunRulesPagerdutyAlertSchemaType.Pagerduty,
                _ => null,
            };
        }
    }
}
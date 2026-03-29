//HintName: G.Models.AlertPublicAlertType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertPublicAlertType
    {
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        Pagerduty,
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertPublicAlertTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertPublicAlertType value)
        {
            return value switch
            {
                AlertPublicAlertType.General => "general",
                AlertPublicAlertType.Pagerduty => "pagerduty",
                AlertPublicAlertType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertPublicAlertType? ToEnum(string value)
        {
            return value switch
            {
                "general" => AlertPublicAlertType.General,
                "pagerduty" => AlertPublicAlertType.Pagerduty,
                "slack" => AlertPublicAlertType.Slack,
                _ => null,
            };
        }
    }
}
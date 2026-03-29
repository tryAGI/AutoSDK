//HintName: G.Models.AlertWriteAlertType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertWriteAlertType
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
    public static class AlertWriteAlertTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertWriteAlertType value)
        {
            return value switch
            {
                AlertWriteAlertType.General => "general",
                AlertWriteAlertType.Pagerduty => "pagerduty",
                AlertWriteAlertType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertWriteAlertType? ToEnum(string value)
        {
            return value switch
            {
                "general" => AlertWriteAlertType.General,
                "pagerduty" => AlertWriteAlertType.Pagerduty,
                "slack" => AlertWriteAlertType.Slack,
                _ => null,
            };
        }
    }
}
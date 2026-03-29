//HintName: G.Models.AlertAlertType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertAlertType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="general")]
        General,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pagerduty")]
        Pagerduty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack")]
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertAlertTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertAlertType value)
        {
            return value switch
            {
                AlertAlertType.General => "general",
                AlertAlertType.Pagerduty => "pagerduty",
                AlertAlertType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertAlertType? ToEnum(string value)
        {
            return value switch
            {
                "general" => AlertAlertType.General,
                "pagerduty" => AlertAlertType.Pagerduty,
                "slack" => AlertAlertType.Slack,
                _ => null,
            };
        }
    }
}
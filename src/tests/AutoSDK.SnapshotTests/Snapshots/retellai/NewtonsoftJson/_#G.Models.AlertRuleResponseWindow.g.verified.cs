//HintName: G.Models.AlertRuleResponseWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Time window for metric evaluation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertRuleResponseWindow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="12h")]
        x12h,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1h")]
        x1h,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1m")]
        x1m,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="24h")]
        x24h,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="30m")]
        x30m,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3d")]
        x3d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="5m")]
        x5m,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="7d")]
        x7d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertRuleResponseWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertRuleResponseWindow value)
        {
            return value switch
            {
                AlertRuleResponseWindow.x12h => "12h",
                AlertRuleResponseWindow.x1h => "1h",
                AlertRuleResponseWindow.x1m => "1m",
                AlertRuleResponseWindow.x24h => "24h",
                AlertRuleResponseWindow.x30m => "30m",
                AlertRuleResponseWindow.x3d => "3d",
                AlertRuleResponseWindow.x5m => "5m",
                AlertRuleResponseWindow.x7d => "7d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertRuleResponseWindow? ToEnum(string value)
        {
            return value switch
            {
                "12h" => AlertRuleResponseWindow.x12h,
                "1h" => AlertRuleResponseWindow.x1h,
                "1m" => AlertRuleResponseWindow.x1m,
                "24h" => AlertRuleResponseWindow.x24h,
                "30m" => AlertRuleResponseWindow.x30m,
                "3d" => AlertRuleResponseWindow.x3d,
                "5m" => AlertRuleResponseWindow.x5m,
                "7d" => AlertRuleResponseWindow.x7d,
                _ => null,
            };
        }
    }
}
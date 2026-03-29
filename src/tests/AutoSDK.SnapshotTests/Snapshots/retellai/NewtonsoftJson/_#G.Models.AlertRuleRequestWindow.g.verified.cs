//HintName: G.Models.AlertRuleRequestWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Time window for metric evaluation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertRuleRequestWindow
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
    public static class AlertRuleRequestWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertRuleRequestWindow value)
        {
            return value switch
            {
                AlertRuleRequestWindow.x12h => "12h",
                AlertRuleRequestWindow.x1h => "1h",
                AlertRuleRequestWindow.x1m => "1m",
                AlertRuleRequestWindow.x24h => "24h",
                AlertRuleRequestWindow.x30m => "30m",
                AlertRuleRequestWindow.x3d => "3d",
                AlertRuleRequestWindow.x5m => "5m",
                AlertRuleRequestWindow.x7d => "7d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertRuleRequestWindow? ToEnum(string value)
        {
            return value switch
            {
                "12h" => AlertRuleRequestWindow.x12h,
                "1h" => AlertRuleRequestWindow.x1h,
                "1m" => AlertRuleRequestWindow.x1m,
                "24h" => AlertRuleRequestWindow.x24h,
                "30m" => AlertRuleRequestWindow.x30m,
                "3d" => AlertRuleRequestWindow.x3d,
                "5m" => AlertRuleRequestWindow.x5m,
                "7d" => AlertRuleRequestWindow.x7d,
                _ => null,
            };
        }
    }
}
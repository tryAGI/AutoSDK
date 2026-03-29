//HintName: G.Models.PostInternalTriggerLogsRequestTime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Return logs from the last N time units<br/>
    /// Example: 5m
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostInternalTriggerLogsRequestTime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1d")]
        x1d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1month")]
        x1month,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1w")]
        x1w,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1y")]
        x1y,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="30m")]
        x30m,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="5m")]
        x5m,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="6h")]
        x6h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostInternalTriggerLogsRequestTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostInternalTriggerLogsRequestTime value)
        {
            return value switch
            {
                PostInternalTriggerLogsRequestTime.x1d => "1d",
                PostInternalTriggerLogsRequestTime.x1month => "1month",
                PostInternalTriggerLogsRequestTime.x1w => "1w",
                PostInternalTriggerLogsRequestTime.x1y => "1y",
                PostInternalTriggerLogsRequestTime.x30m => "30m",
                PostInternalTriggerLogsRequestTime.x5m => "5m",
                PostInternalTriggerLogsRequestTime.x6h => "6h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostInternalTriggerLogsRequestTime? ToEnum(string value)
        {
            return value switch
            {
                "1d" => PostInternalTriggerLogsRequestTime.x1d,
                "1month" => PostInternalTriggerLogsRequestTime.x1month,
                "1w" => PostInternalTriggerLogsRequestTime.x1w,
                "1y" => PostInternalTriggerLogsRequestTime.x1y,
                "30m" => PostInternalTriggerLogsRequestTime.x30m,
                "5m" => PostInternalTriggerLogsRequestTime.x5m,
                "6h" => PostInternalTriggerLogsRequestTime.x6h,
                _ => null,
            };
        }
    }
}
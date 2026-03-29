//HintName: G.Models.PostInternalTriggerLogsRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter logs by their status level<br/>
    /// Example: success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostInternalTriggerLogsRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostInternalTriggerLogsRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostInternalTriggerLogsRequestStatus value)
        {
            return value switch
            {
                PostInternalTriggerLogsRequestStatus.All => "all",
                PostInternalTriggerLogsRequestStatus.Error => "error",
                PostInternalTriggerLogsRequestStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostInternalTriggerLogsRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => PostInternalTriggerLogsRequestStatus.All,
                "error" => PostInternalTriggerLogsRequestStatus.Error,
                "success" => PostInternalTriggerLogsRequestStatus.Success,
                _ => null,
            };
        }
    }
}
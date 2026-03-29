//HintName: G.Models.PostInternalActionExecutionLogsResponseDataItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostInternalActionExecutionLogsResponseDataItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostInternalActionExecutionLogsResponseDataItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostInternalActionExecutionLogsResponseDataItemStatus value)
        {
            return value switch
            {
                PostInternalActionExecutionLogsResponseDataItemStatus.Failed => "failed",
                PostInternalActionExecutionLogsResponseDataItemStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostInternalActionExecutionLogsResponseDataItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => PostInternalActionExecutionLogsResponseDataItemStatus.Failed,
                "success" => PostInternalActionExecutionLogsResponseDataItemStatus.Success,
                _ => null,
            };
        }
    }
}
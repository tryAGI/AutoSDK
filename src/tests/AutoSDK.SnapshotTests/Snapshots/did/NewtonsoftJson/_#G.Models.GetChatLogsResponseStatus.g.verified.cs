//HintName: G.Models.GetChatLogsResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates full partial or failed export
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetChatLogsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partial")]
        Partial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetChatLogsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChatLogsResponseStatus value)
        {
            return value switch
            {
                GetChatLogsResponseStatus.Created => "created",
                GetChatLogsResponseStatus.Done => "done",
                GetChatLogsResponseStatus.Error => "error",
                GetChatLogsResponseStatus.Partial => "partial",
                GetChatLogsResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChatLogsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetChatLogsResponseStatus.Created,
                "done" => GetChatLogsResponseStatus.Done,
                "error" => GetChatLogsResponseStatus.Error,
                "partial" => GetChatLogsResponseStatus.Partial,
                "started" => GetChatLogsResponseStatus.Started,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.DeleteChatLogsResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates full partial or failed export
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteChatLogsResponseStatus
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
    public static class DeleteChatLogsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteChatLogsResponseStatus value)
        {
            return value switch
            {
                DeleteChatLogsResponseStatus.Created => "created",
                DeleteChatLogsResponseStatus.Done => "done",
                DeleteChatLogsResponseStatus.Error => "error",
                DeleteChatLogsResponseStatus.Partial => "partial",
                DeleteChatLogsResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteChatLogsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => DeleteChatLogsResponseStatus.Created,
                "done" => DeleteChatLogsResponseStatus.Done,
                "error" => DeleteChatLogsResponseStatus.Error,
                "partial" => DeleteChatLogsResponseStatus.Partial,
                "started" => DeleteChatLogsResponseStatus.Started,
                _ => null,
            };
        }
    }
}
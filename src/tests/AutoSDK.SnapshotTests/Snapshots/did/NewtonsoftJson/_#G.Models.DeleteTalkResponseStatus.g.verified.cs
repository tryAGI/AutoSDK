//HintName: G.Models.DeleteTalkResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the talk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteTalkResponseStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteTalkResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteTalkResponseStatus value)
        {
            return value switch
            {
                DeleteTalkResponseStatus.Created => "created",
                DeleteTalkResponseStatus.Done => "done",
                DeleteTalkResponseStatus.Error => "error",
                DeleteTalkResponseStatus.Rejected => "rejected",
                DeleteTalkResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteTalkResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => DeleteTalkResponseStatus.Created,
                "done" => DeleteTalkResponseStatus.Done,
                "error" => DeleteTalkResponseStatus.Error,
                "rejected" => DeleteTalkResponseStatus.Rejected,
                "started" => DeleteTalkResponseStatus.Started,
                _ => null,
            };
        }
    }
}
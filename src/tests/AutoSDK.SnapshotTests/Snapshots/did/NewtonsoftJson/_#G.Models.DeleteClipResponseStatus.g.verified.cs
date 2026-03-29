//HintName: G.Models.DeleteClipResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the clip
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteClipResponseStatus
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
    public static class DeleteClipResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteClipResponseStatus value)
        {
            return value switch
            {
                DeleteClipResponseStatus.Created => "created",
                DeleteClipResponseStatus.Done => "done",
                DeleteClipResponseStatus.Error => "error",
                DeleteClipResponseStatus.Rejected => "rejected",
                DeleteClipResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteClipResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => DeleteClipResponseStatus.Created,
                "done" => DeleteClipResponseStatus.Done,
                "error" => DeleteClipResponseStatus.Error,
                "rejected" => DeleteClipResponseStatus.Rejected,
                "started" => DeleteClipResponseStatus.Started,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.GetClipResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the clip
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetClipResponseStatus
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
    public static class GetClipResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipResponseStatus value)
        {
            return value switch
            {
                GetClipResponseStatus.Created => "created",
                GetClipResponseStatus.Done => "done",
                GetClipResponseStatus.Error => "error",
                GetClipResponseStatus.Rejected => "rejected",
                GetClipResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetClipResponseStatus.Created,
                "done" => GetClipResponseStatus.Done,
                "error" => GetClipResponseStatus.Error,
                "rejected" => GetClipResponseStatus.Rejected,
                "started" => GetClipResponseStatus.Started,
                _ => null,
            };
        }
    }
}
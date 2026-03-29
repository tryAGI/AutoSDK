//HintName: G.Models.GetClipsResponseClipStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the clip
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetClipsResponseClipStatus
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
    public static class GetClipsResponseClipStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipsResponseClipStatus value)
        {
            return value switch
            {
                GetClipsResponseClipStatus.Created => "created",
                GetClipsResponseClipStatus.Done => "done",
                GetClipsResponseClipStatus.Error => "error",
                GetClipsResponseClipStatus.Rejected => "rejected",
                GetClipsResponseClipStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipsResponseClipStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetClipsResponseClipStatus.Created,
                "done" => GetClipsResponseClipStatus.Done,
                "error" => GetClipsResponseClipStatus.Error,
                "rejected" => GetClipsResponseClipStatus.Rejected,
                "started" => GetClipsResponseClipStatus.Started,
                _ => null,
            };
        }
    }
}
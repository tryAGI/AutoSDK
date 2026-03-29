//HintName: G.Models.ClipAvatarStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipAvatarStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="draft")]
        Draft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="post-done")]
        PostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipAvatarStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipAvatarStatus value)
        {
            return value switch
            {
                ClipAvatarStatus.Created => "created",
                ClipAvatarStatus.Done => "done",
                ClipAvatarStatus.Draft => "draft",
                ClipAvatarStatus.Error => "error",
                ClipAvatarStatus.PostDone => "post-done",
                ClipAvatarStatus.Ready => "ready",
                ClipAvatarStatus.Rejected => "rejected",
                ClipAvatarStatus.Started => "started",
                ClipAvatarStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipAvatarStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => ClipAvatarStatus.Created,
                "done" => ClipAvatarStatus.Done,
                "draft" => ClipAvatarStatus.Draft,
                "error" => ClipAvatarStatus.Error,
                "post-done" => ClipAvatarStatus.PostDone,
                "ready" => ClipAvatarStatus.Ready,
                "rejected" => ClipAvatarStatus.Rejected,
                "started" => ClipAvatarStatus.Started,
                "validating" => ClipAvatarStatus.Validating,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ClipAvatarStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClipAvatarStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        PostDone,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
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
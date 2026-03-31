//HintName: G.Models.GetClipsResponseClipStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the clip
    /// </summary>
    public enum GetClipsResponseClipStatus2
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
        Error,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetClipsResponseClipStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipsResponseClipStatus2 value)
        {
            return value switch
            {
                GetClipsResponseClipStatus2.Created => "created",
                GetClipsResponseClipStatus2.Done => "done",
                GetClipsResponseClipStatus2.Error => "error",
                GetClipsResponseClipStatus2.Rejected => "rejected",
                GetClipsResponseClipStatus2.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipsResponseClipStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetClipsResponseClipStatus2.Created,
                "done" => GetClipsResponseClipStatus2.Done,
                "error" => GetClipsResponseClipStatus2.Error,
                "rejected" => GetClipsResponseClipStatus2.Rejected,
                "started" => GetClipsResponseClipStatus2.Started,
                _ => null,
            };
        }
    }
}
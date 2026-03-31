//HintName: G.Models.GetClipResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the clip
    /// </summary>
    public enum GetClipResponseStatus2
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
    public static class GetClipResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipResponseStatus2 value)
        {
            return value switch
            {
                GetClipResponseStatus2.Created => "created",
                GetClipResponseStatus2.Done => "done",
                GetClipResponseStatus2.Error => "error",
                GetClipResponseStatus2.Rejected => "rejected",
                GetClipResponseStatus2.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetClipResponseStatus2.Created,
                "done" => GetClipResponseStatus2.Done,
                "error" => GetClipResponseStatus2.Error,
                "rejected" => GetClipResponseStatus2.Rejected,
                "started" => GetClipResponseStatus2.Started,
                _ => null,
            };
        }
    }
}
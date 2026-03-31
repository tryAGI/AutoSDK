//HintName: G.Models.CreateClipResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the clip
    /// </summary>
    public enum CreateClipResponseStatus2
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
    public static class CreateClipResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipResponseStatus2 value)
        {
            return value switch
            {
                CreateClipResponseStatus2.Created => "created",
                CreateClipResponseStatus2.Done => "done",
                CreateClipResponseStatus2.Error => "error",
                CreateClipResponseStatus2.Rejected => "rejected",
                CreateClipResponseStatus2.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateClipResponseStatus2.Created,
                "done" => CreateClipResponseStatus2.Done,
                "error" => CreateClipResponseStatus2.Error,
                "rejected" => CreateClipResponseStatus2.Rejected,
                "started" => CreateClipResponseStatus2.Started,
                _ => null,
            };
        }
    }
}
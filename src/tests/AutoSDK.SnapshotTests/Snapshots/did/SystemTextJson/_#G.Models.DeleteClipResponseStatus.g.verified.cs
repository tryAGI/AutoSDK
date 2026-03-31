//HintName: G.Models.DeleteClipResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the clip
    /// </summary>
    public enum DeleteClipResponseStatus
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
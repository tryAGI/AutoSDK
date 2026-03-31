//HintName: G.Models.CreateClipResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the clip
    /// </summary>
    public enum CreateClipResponseStatus
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
    public static class CreateClipResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipResponseStatus value)
        {
            return value switch
            {
                CreateClipResponseStatus.Created => "created",
                CreateClipResponseStatus.Done => "done",
                CreateClipResponseStatus.Error => "error",
                CreateClipResponseStatus.Rejected => "rejected",
                CreateClipResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateClipResponseStatus.Created,
                "done" => CreateClipResponseStatus.Done,
                "error" => CreateClipResponseStatus.Error,
                "rejected" => CreateClipResponseStatus.Rejected,
                "started" => CreateClipResponseStatus.Started,
                _ => null,
            };
        }
    }
}
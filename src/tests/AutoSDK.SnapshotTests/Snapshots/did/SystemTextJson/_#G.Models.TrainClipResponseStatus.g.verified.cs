//HintName: G.Models.TrainClipResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrainClipResponseStatus
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
    public static class TrainClipResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainClipResponseStatus value)
        {
            return value switch
            {
                TrainClipResponseStatus.Created => "created",
                TrainClipResponseStatus.Done => "done",
                TrainClipResponseStatus.Draft => "draft",
                TrainClipResponseStatus.Error => "error",
                TrainClipResponseStatus.PostDone => "post-done",
                TrainClipResponseStatus.Ready => "ready",
                TrainClipResponseStatus.Rejected => "rejected",
                TrainClipResponseStatus.Started => "started",
                TrainClipResponseStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainClipResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => TrainClipResponseStatus.Created,
                "done" => TrainClipResponseStatus.Done,
                "draft" => TrainClipResponseStatus.Draft,
                "error" => TrainClipResponseStatus.Error,
                "post-done" => TrainClipResponseStatus.PostDone,
                "ready" => TrainClipResponseStatus.Ready,
                "rejected" => TrainClipResponseStatus.Rejected,
                "started" => TrainClipResponseStatus.Started,
                "validating" => TrainClipResponseStatus.Validating,
                _ => null,
            };
        }
    }
}
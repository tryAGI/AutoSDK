//HintName: G.Models.TrainClipResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TrainClipResponseStatus
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
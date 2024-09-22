//HintName: G.Models.Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The possible stages of a fine-tuned model life-cycle.<br/>
    ///  - STATUS_UNSPECIFIED: Unspecified status.<br/>
    ///  - STATUS_FINETUNING: The fine-tuned model is being fine-tuned.<br/>
    ///  - STATUS_DEPLOYING_API: The fine-tuned model is being deployed.<br/>
    ///  - STATUS_READY: The fine-tuned model is ready to receive requests.<br/>
    ///  - STATUS_FAILED: The fine-tuned model failed.<br/>
    ///  - STATUS_DELETED: The fine-tuned model was deleted.<br/>
    ///  - STATUS_TEMPORARILY_OFFLINE: The fine-tuned model is temporarily unavailable.<br/>
    ///  - STATUS_PAUSED: The fine-tuned model is paused (Vanilla only).<br/>
    ///  - STATUS_QUEUED: The fine-tuned model is queued for training.<br/>
    /// Default Value: STATUS_UNSPECIFIED
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Unspecified status.
        /// </summary>
        STATUSUNSPECIFIED,
        /// <summary>
        /// The fine-tuned model is being fine-tuned.
        /// </summary>
        STATUSFINETUNING,
        /// <summary>
        /// The fine-tuned model is being deployed.
        /// </summary>
        STATUSDEPLOYINGAPI,
        /// <summary>
        /// The fine-tuned model is ready to receive requests.
        /// </summary>
        STATUSREADY,
        /// <summary>
        /// The fine-tuned model failed.
        /// </summary>
        STATUSFAILED,
        /// <summary>
        /// The fine-tuned model was deleted.
        /// </summary>
        STATUSDELETED,
        /// <summary>
        /// The fine-tuned model is temporarily unavailable.
        /// </summary>
        STATUSTEMPORARILYOFFLINE,
        /// <summary>
        /// The fine-tuned model is paused (Vanilla only).
        /// </summary>
        STATUSPAUSED,
        /// <summary>
        /// The fine-tuned model is queued for training.
        /// </summary>
        STATUSQUEUED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Status value)
        {
            return value switch
            {
                Status.STATUSUNSPECIFIED => "STATUS_UNSPECIFIED",
                Status.STATUSFINETUNING => "STATUS_FINETUNING",
                Status.STATUSDEPLOYINGAPI => "STATUS_DEPLOYING_API",
                Status.STATUSREADY => "STATUS_READY",
                Status.STATUSFAILED => "STATUS_FAILED",
                Status.STATUSDELETED => "STATUS_DELETED",
                Status.STATUSTEMPORARILYOFFLINE => "STATUS_TEMPORARILY_OFFLINE",
                Status.STATUSPAUSED => "STATUS_PAUSED",
                Status.STATUSQUEUED => "STATUS_QUEUED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Status? ToEnum(string value)
        {
            return value switch
            {
                "STATUS_UNSPECIFIED" => Status.STATUSUNSPECIFIED,
                "STATUS_FINETUNING" => Status.STATUSFINETUNING,
                "STATUS_DEPLOYING_API" => Status.STATUSDEPLOYINGAPI,
                "STATUS_READY" => Status.STATUSREADY,
                "STATUS_FAILED" => Status.STATUSFAILED,
                "STATUS_DELETED" => Status.STATUSDELETED,
                "STATUS_TEMPORARILY_OFFLINE" => Status.STATUSTEMPORARILYOFFLINE,
                "STATUS_PAUSED" => Status.STATUSPAUSED,
                "STATUS_QUEUED" => Status.STATUSQUEUED,
                _ => null,
            };
        }
    }
}
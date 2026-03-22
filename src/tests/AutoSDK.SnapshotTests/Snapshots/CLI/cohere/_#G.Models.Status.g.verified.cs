//HintName: G.Models.Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The possible stages of a fine-tuned model life-cycle.<br/>
    ///  - STATUS_UNSPECIFIED: Unspecified status.<br/>
    ///  - STATUS_FINETUNING: The fine-tuned model is being fine-tuned.<br/>
    ///  - STATUS_DEPLOYING_API: Deprecated: The fine-tuned model is being deployed.<br/>
    ///  - STATUS_READY: The fine-tuned model is ready to receive requests.<br/>
    ///  - STATUS_FAILED: The fine-tuned model failed.<br/>
    ///  - STATUS_DELETED: The fine-tuned model was deleted.<br/>
    ///  - STATUS_TEMPORARILY_OFFLINE: Deprecated: The fine-tuned model is temporarily unavailable.<br/>
    ///  - STATUS_PAUSED: Deprecated: The fine-tuned model is paused (Vanilla only).<br/>
    ///  - STATUS_QUEUED: The fine-tuned model is queued for training.<br/>
    /// Default Value: STATUS_UNSPECIFIED
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// The fine-tuned model was deleted.
        /// </summary>
        Deleted,
        /// <summary>
        /// Deprecated: The fine-tuned model is being deployed.
        /// </summary>
        DeployingApi,
        /// <summary>
        /// The fine-tuned model failed.
        /// </summary>
        Failed,
        /// <summary>
        /// The fine-tuned model is being fine-tuned.
        /// </summary>
        Finetuning,
        /// <summary>
        /// Deprecated: The fine-tuned model is paused (Vanilla only).
        /// </summary>
        Paused,
        /// <summary>
        /// The fine-tuned model is queued for training.
        /// </summary>
        Queued,
        /// <summary>
        /// The fine-tuned model is ready to receive requests.
        /// </summary>
        Ready,
        /// <summary>
        /// Deprecated: The fine-tuned model is temporarily unavailable.
        /// </summary>
        TemporarilyOffline,
        /// <summary>
        /// Unspecified status.
        /// </summary>
        Unspecified,
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
                Status.Deleted => "STATUS_DELETED",
                Status.DeployingApi => "STATUS_DEPLOYING_API",
                Status.Failed => "STATUS_FAILED",
                Status.Finetuning => "STATUS_FINETUNING",
                Status.Paused => "STATUS_PAUSED",
                Status.Queued => "STATUS_QUEUED",
                Status.Ready => "STATUS_READY",
                Status.TemporarilyOffline => "STATUS_TEMPORARILY_OFFLINE",
                Status.Unspecified => "STATUS_UNSPECIFIED",
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
                "STATUS_DELETED" => Status.Deleted,
                "STATUS_DEPLOYING_API" => Status.DeployingApi,
                "STATUS_FAILED" => Status.Failed,
                "STATUS_FINETUNING" => Status.Finetuning,
                "STATUS_PAUSED" => Status.Paused,
                "STATUS_QUEUED" => Status.Queued,
                "STATUS_READY" => Status.Ready,
                "STATUS_TEMPORARILY_OFFLINE" => Status.TemporarilyOffline,
                "STATUS_UNSPECIFIED" => Status.Unspecified,
                _ => null,
            };
        }
    }
}
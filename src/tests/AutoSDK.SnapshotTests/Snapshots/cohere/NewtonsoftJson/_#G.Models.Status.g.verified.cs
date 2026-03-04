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
    [global::System.Runtime.Serialization.DataContract]
    public enum Status
    {
        /// <summary>
        /// Unspecified status.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_UNSPECIFIED")]
        Unspecified,
        /// <summary>
        /// The fine-tuned model is being fine-tuned.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_FINETUNING")]
        Finetuning,
        /// <summary>
        /// Deprecated: The fine-tuned model is being deployed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_DEPLOYING_API")]
        DeployingApi,
        /// <summary>
        /// The fine-tuned model is ready to receive requests.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_READY")]
        Ready,
        /// <summary>
        /// The fine-tuned model failed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_FAILED")]
        Failed,
        /// <summary>
        /// The fine-tuned model was deleted.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_DELETED")]
        Deleted,
        /// <summary>
        /// Deprecated: The fine-tuned model is temporarily unavailable.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_TEMPORARILY_OFFLINE")]
        TemporarilyOffline,
        /// <summary>
        /// Deprecated: The fine-tuned model is paused (Vanilla only).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_PAUSED")]
        Paused,
        /// <summary>
        /// The fine-tuned model is queued for training.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_QUEUED")]
        Queued,
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
                Status.Unspecified => "STATUS_UNSPECIFIED",
                Status.Finetuning => "STATUS_FINETUNING",
                Status.DeployingApi => "STATUS_DEPLOYING_API",
                Status.Ready => "STATUS_READY",
                Status.Failed => "STATUS_FAILED",
                Status.Deleted => "STATUS_DELETED",
                Status.TemporarilyOffline => "STATUS_TEMPORARILY_OFFLINE",
                Status.Paused => "STATUS_PAUSED",
                Status.Queued => "STATUS_QUEUED",
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
                "STATUS_UNSPECIFIED" => Status.Unspecified,
                "STATUS_FINETUNING" => Status.Finetuning,
                "STATUS_DEPLOYING_API" => Status.DeployingApi,
                "STATUS_READY" => Status.Ready,
                "STATUS_FAILED" => Status.Failed,
                "STATUS_DELETED" => Status.Deleted,
                "STATUS_TEMPORARILY_OFFLINE" => Status.TemporarilyOffline,
                "STATUS_PAUSED" => Status.Paused,
                "STATUS_QUEUED" => Status.Queued,
                _ => null,
            };
        }
    }
}
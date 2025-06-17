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
        UNSPECIFIED,
        /// <summary>
        /// The fine-tuned model is being fine-tuned.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_FINETUNING")]
        FINETUNING,
        /// <summary>
        /// Deprecated: The fine-tuned model is being deployed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_DEPLOYING_API")]
        DEPLOYINGAPI,
        /// <summary>
        /// The fine-tuned model is ready to receive requests.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_READY")]
        READY,
        /// <summary>
        /// The fine-tuned model failed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_FAILED")]
        FAILED,
        /// <summary>
        /// The fine-tuned model was deleted.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_DELETED")]
        DELETED,
        /// <summary>
        /// Deprecated: The fine-tuned model is temporarily unavailable.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_TEMPORARILY_OFFLINE")]
        TEMPORARILYOFFLINE,
        /// <summary>
        /// Deprecated: The fine-tuned model is paused (Vanilla only).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_PAUSED")]
        PAUSED,
        /// <summary>
        /// The fine-tuned model is queued for training.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_QUEUED")]
        QUEUED,
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
                Status.UNSPECIFIED => "STATUS_UNSPECIFIED",
                Status.FINETUNING => "STATUS_FINETUNING",
                Status.DEPLOYINGAPI => "STATUS_DEPLOYING_API",
                Status.READY => "STATUS_READY",
                Status.FAILED => "STATUS_FAILED",
                Status.DELETED => "STATUS_DELETED",
                Status.TEMPORARILYOFFLINE => "STATUS_TEMPORARILY_OFFLINE",
                Status.PAUSED => "STATUS_PAUSED",
                Status.QUEUED => "STATUS_QUEUED",
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
                "STATUS_UNSPECIFIED" => Status.UNSPECIFIED,
                "STATUS_FINETUNING" => Status.FINETUNING,
                "STATUS_DEPLOYING_API" => Status.DEPLOYINGAPI,
                "STATUS_READY" => Status.READY,
                "STATUS_FAILED" => Status.FAILED,
                "STATUS_DELETED" => Status.DELETED,
                "STATUS_TEMPORARILY_OFFLINE" => Status.TEMPORARILYOFFLINE,
                "STATUS_PAUSED" => Status.PAUSED,
                "STATUS_QUEUED" => Status.QUEUED,
                _ => null,
            };
        }
    }
}
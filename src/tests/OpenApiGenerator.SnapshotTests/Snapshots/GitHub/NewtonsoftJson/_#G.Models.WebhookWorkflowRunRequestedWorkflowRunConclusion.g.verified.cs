//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowRunRequestedWorkflowRunConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup_failure")]
        StartupFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowRunRequestedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunRequestedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Success => "success",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Failure => "failure",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Neutral => "neutral",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.TimedOut => "timed_out",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Stale => "stale",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Skipped => "skipped",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.StartupFailure => "startup_failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunRequestedWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Success,
                "failure" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Failure,
                "neutral" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Neutral,
                "cancelled" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Cancelled,
                "timed_out" => WebhookWorkflowRunRequestedWorkflowRunConclusion.TimedOut,
                "action_required" => WebhookWorkflowRunRequestedWorkflowRunConclusion.ActionRequired,
                "stale" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Stale,
                "skipped" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Skipped,
                "startup_failure" => WebhookWorkflowRunRequestedWorkflowRunConclusion.StartupFailure,
                _ => null,
            };
        }
    }
}
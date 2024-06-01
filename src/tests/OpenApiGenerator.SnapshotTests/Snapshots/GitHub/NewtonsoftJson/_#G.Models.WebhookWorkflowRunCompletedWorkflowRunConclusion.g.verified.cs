//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowRunCompletedWorkflowRunConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
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
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowRunCompletedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunCompletedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookWorkflowRunCompletedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookWorkflowRunCompletedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookWorkflowRunCompletedWorkflowRunConclusion.Failure => "failure",
                WebhookWorkflowRunCompletedWorkflowRunConclusion.Neutral => "neutral",
                WebhookWorkflowRunCompletedWorkflowRunConclusion.Skipped => "skipped",
                WebhookWorkflowRunCompletedWorkflowRunConclusion.Stale => "stale",
                WebhookWorkflowRunCompletedWorkflowRunConclusion.Success => "success",
                WebhookWorkflowRunCompletedWorkflowRunConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunConclusion ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookWorkflowRunCompletedWorkflowRunConclusion.ActionRequired,
                "cancelled" => WebhookWorkflowRunCompletedWorkflowRunConclusion.Cancelled,
                "failure" => WebhookWorkflowRunCompletedWorkflowRunConclusion.Failure,
                "neutral" => WebhookWorkflowRunCompletedWorkflowRunConclusion.Neutral,
                "skipped" => WebhookWorkflowRunCompletedWorkflowRunConclusion.Skipped,
                "stale" => WebhookWorkflowRunCompletedWorkflowRunConclusion.Stale,
                "success" => WebhookWorkflowRunCompletedWorkflowRunConclusion.Success,
                "timed_out" => WebhookWorkflowRunCompletedWorkflowRunConclusion.TimedOut,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookDeploymentStatusCreatedCheckRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the completed check run. This value will be `null` until the check run has completed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedCheckRunConclusion
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
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
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
    public static class WebhookDeploymentStatusCreatedCheckRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedCheckRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedCheckRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Failure => "failure",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Neutral => "neutral",
                WebhookDeploymentStatusCreatedCheckRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Skipped => "skipped",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Stale => "stale",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Success => "success",
                WebhookDeploymentStatusCreatedCheckRunConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedCheckRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookDeploymentStatusCreatedCheckRunConclusion.ActionRequired,
                "cancelled" => WebhookDeploymentStatusCreatedCheckRunConclusion.Cancelled,
                "failure" => WebhookDeploymentStatusCreatedCheckRunConclusion.Failure,
                "neutral" => WebhookDeploymentStatusCreatedCheckRunConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookDeploymentStatusCreatedCheckRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookDeploymentStatusCreatedCheckRunConclusion.Skipped,
                "stale" => WebhookDeploymentStatusCreatedCheckRunConclusion.Stale,
                "success" => WebhookDeploymentStatusCreatedCheckRunConclusion.Success,
                "timed_out" => WebhookDeploymentStatusCreatedCheckRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}
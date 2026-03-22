//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Cancelled => "cancelled",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Failure => "failure",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Neutral => "neutral",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Cancelled,
                "failure" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Failure,
                "neutral" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "success" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Success,
                _ => null,
            };
        }
    }
}
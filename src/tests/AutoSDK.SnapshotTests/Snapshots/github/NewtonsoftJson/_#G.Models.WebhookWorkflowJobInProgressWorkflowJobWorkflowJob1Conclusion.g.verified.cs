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
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
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
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Success => "success",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Failure => "failure",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Cancelled => "cancelled",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Neutral => "neutral",
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
                "success" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Success,
                "failure" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Failure,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                "cancelled" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Cancelled,
                "neutral" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion.Neutral,
                _ => null,
            };
        }
    }
}
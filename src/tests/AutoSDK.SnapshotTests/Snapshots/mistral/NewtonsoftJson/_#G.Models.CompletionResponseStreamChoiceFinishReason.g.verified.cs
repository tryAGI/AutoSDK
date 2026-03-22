//HintName: G.Models.CompletionResponseStreamChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletionResponseStreamChoiceFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="length")]
        Length,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop")]
        Stop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_calls")]
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionResponseStreamChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionResponseStreamChoiceFinishReason value)
        {
            return value switch
            {
                CompletionResponseStreamChoiceFinishReason.Error => "error",
                CompletionResponseStreamChoiceFinishReason.Length => "length",
                CompletionResponseStreamChoiceFinishReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                CompletionResponseStreamChoiceFinishReason.Stop => "stop",
                CompletionResponseStreamChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionResponseStreamChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "error" => CompletionResponseStreamChoiceFinishReason.Error,
                "length" => CompletionResponseStreamChoiceFinishReason.Length,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => CompletionResponseStreamChoiceFinishReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "stop" => CompletionResponseStreamChoiceFinishReason.Stop,
                "tool_calls" => CompletionResponseStreamChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}
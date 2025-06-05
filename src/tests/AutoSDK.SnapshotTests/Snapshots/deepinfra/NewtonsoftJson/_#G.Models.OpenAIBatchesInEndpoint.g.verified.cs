//HintName: G.Models.OpenAIBatchesInEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The endpoint to be used for all requests in the batch. Currently /v1/chat/completions, /v1/completions are supported.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIBatchesInEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/chat/completions")]
        V1ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/completions")]
        V1Completions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIBatchesInEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIBatchesInEndpoint value)
        {
            return value switch
            {
                OpenAIBatchesInEndpoint.V1ChatCompletions => "/v1/chat/completions",
                OpenAIBatchesInEndpoint.V1Completions => "/v1/completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIBatchesInEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/chat/completions" => OpenAIBatchesInEndpoint.V1ChatCompletions,
                "/v1/completions" => OpenAIBatchesInEndpoint.V1Completions,
                _ => null,
            };
        }
    }
}
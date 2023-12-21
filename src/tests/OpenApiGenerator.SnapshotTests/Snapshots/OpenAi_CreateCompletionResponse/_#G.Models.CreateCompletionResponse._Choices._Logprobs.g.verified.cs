//HintName: G.Models.CreateCompletionResponse._Choices._Logprobs.g.cs

#nullable enable

namespace G
{
    public sealed partial class CreateCompletionResponse
    {
        public sealed partial class _Choices
        {
            /// <summary>
            /// 
            /// </summary>
            public sealed partial class _Logprobs
            {
                /// <summary>
                /// 
                /// </summary>
                [global::System.Text.Json.Serialization.JsonPropertyName("text_offset")]
                public int[]? TextOffset { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [global::System.Text.Json.Serialization.JsonPropertyName("token_logprobs")]
                public double[]? TokenLogprobs { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
                public string?[]? Tokens { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
                public CreateCompletionResponse._Choices._Logprobs._TopLogprobs?[]? TopLogprobs { get; set; }

                [global::System.Text.Json.Serialization.JsonExtensionData]
                public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
            }
        }
    }
}
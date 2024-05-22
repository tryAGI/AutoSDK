//HintName: G.Models.Logprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Logprobs
    {
        /// <summary>
        /// <br/>Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<string?>? Tokens { get; set; }

        /// <summary>
        /// <br/>Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_logprobs")]
        public global::System.Collections.Generic.IList<double>? TokenLogprobs { get; set; }

        /// <summary>
        /// <br/>Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public global::System.Collections.Generic.IList<object?>? TopLogprobs { get; set; }

        /// <summary>
        /// <br/>Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_offset")]
        public global::System.Collections.Generic.IList<int>? TextOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
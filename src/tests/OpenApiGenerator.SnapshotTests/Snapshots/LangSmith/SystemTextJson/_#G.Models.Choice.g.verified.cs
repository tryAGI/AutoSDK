//HintName: G.Models.Choice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Choice
    {
        /// <summary>
        /// <br/>Default Value: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; } = "";

        /// <summary>
        /// <br/>Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int Index { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public Logprobs? Logprobs { get; set; }

        /// <summary>
        /// <br/>Default Value: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; } = "";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
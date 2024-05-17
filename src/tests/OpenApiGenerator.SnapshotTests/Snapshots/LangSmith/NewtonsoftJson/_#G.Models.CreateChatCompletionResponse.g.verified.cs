//HintName: G.Models.CreateChatCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionResponse
    {
        /// <summary>
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; } = "";

        /// <summary>
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; } = "";

        /// <summary>
        /// <br/>Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int Created { get; set; } = 0;

        /// <summary>
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; } = "";

        /// <summary>
        /// <br/>Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices")]
        public global::System.Collections.Generic.IList<ChatCompletionChoice?>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public CompletionUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
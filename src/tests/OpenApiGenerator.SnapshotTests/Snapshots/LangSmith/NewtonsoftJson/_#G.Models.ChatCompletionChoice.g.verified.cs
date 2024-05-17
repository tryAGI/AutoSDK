//HintName: G.Models.ChatCompletionChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChoice
    {
        /// <summary>
        /// <br/>Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int Index { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public ChatCompletionResponseMessage? Message { get; set; }

        /// <summary>
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        public string? FinishReason { get; set; } = "";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
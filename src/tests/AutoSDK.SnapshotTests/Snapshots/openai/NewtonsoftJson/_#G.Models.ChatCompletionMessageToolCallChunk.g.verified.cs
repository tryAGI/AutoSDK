//HintName: G.Models.ChatCompletionMessageToolCallChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageToolCallChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ChatCompletionMessageToolCallChunkFunction? Function { get; set; }

        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The type of the tool. Currently, only `function` is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionMessageToolCallChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageToolCallChunk" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="id">
        /// The ID of the tool call.
        /// </param>
        /// <param name="index"></param>
        /// <param name="type">
        /// The type of the tool. Currently, only `function` is supported.
        /// </param>
        public ChatCompletionMessageToolCallChunk(
            int index,
            global::G.ChatCompletionMessageToolCallChunkFunction? function,
            string? id,
            global::G.ChatCompletionMessageToolCallChunkType? type)
        {
            this.Index = index;
            this.Function = function;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageToolCallChunk" /> class.
        /// </summary>
        public ChatCompletionMessageToolCallChunk()
        {
        }
    }
}
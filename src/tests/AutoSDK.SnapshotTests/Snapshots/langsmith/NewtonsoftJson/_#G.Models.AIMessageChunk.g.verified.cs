//HintName: G.Models.AIMessageChunk.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Message chunk from an AI.
    /// </summary>
    public sealed partial class AIMessageChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_kwargs")]
        public object? AdditionalKwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_metadata")]
        public object? ResponseMetadata { get; set; }

        /// <summary>
        /// Default Value: AIMessageChunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AIMessageChunkType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("example")]
        public bool? Example { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invalid_tool_calls")]
        public global::System.Collections.Generic.IList<global::G.InvalidToolCall>? InvalidToolCalls { get; set; }

        /// <summary>
        /// Usage metadata for a message, such as token counts.<br/>
        /// This is a standard representation of token usage that is consistent across models.<br/>
        /// Example:<br/>
        ///     .. code-block:: python<br/>
        ///         {<br/>
        ///             "input_tokens": 350,<br/>
        ///             "output_tokens": 240,<br/>
        ///             "total_tokens": 590,<br/>
        ///             "input_token_details": {<br/>
        ///                 "audio": 10,<br/>
        ///                 "cache_creation": 200,<br/>
        ///                 "cache_read": 100,<br/>
        ///             },<br/>
        ///             "output_token_details": {<br/>
        ///                 "audio": 10,<br/>
        ///                 "reasoning": 200,<br/>
        ///             }<br/>
        ///         }<br/>
        /// .. versionchanged:: 0.3.9<br/>
        ///     Added ``input_token_details`` and ``output_token_details``.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_metadata")]
        public global::G.UsageMetadata? UsageMetadata { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_chunks")]
        public global::System.Collections.Generic.IList<global::G.ToolCallChunk>? ToolCallChunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIMessageChunk" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: AIMessageChunk
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="example">
        /// Default Value: false
        /// </param>
        /// <param name="toolCalls">
        /// Default Value: []
        /// </param>
        /// <param name="invalidToolCalls">
        /// Default Value: []
        /// </param>
        /// <param name="usageMetadata">
        /// Usage metadata for a message, such as token counts.<br/>
        /// This is a standard representation of token usage that is consistent across models.<br/>
        /// Example:<br/>
        ///     .. code-block:: python<br/>
        ///         {<br/>
        ///             "input_tokens": 350,<br/>
        ///             "output_tokens": 240,<br/>
        ///             "total_tokens": 590,<br/>
        ///             "input_token_details": {<br/>
        ///                 "audio": 10,<br/>
        ///                 "cache_creation": 200,<br/>
        ///                 "cache_read": 100,<br/>
        ///             },<br/>
        ///             "output_token_details": {<br/>
        ///                 "audio": 10,<br/>
        ///                 "reasoning": 200,<br/>
        ///             }<br/>
        ///         }<br/>
        /// .. versionchanged:: 0.3.9<br/>
        ///     Added ``input_token_details`` and ``output_token_details``.
        /// </param>
        /// <param name="toolCallChunks">
        /// Default Value: []
        /// </param>
        public AIMessageChunk(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> content,
            object? additionalKwargs,
            object? responseMetadata,
            global::G.AIMessageChunkType? type,
            string? name,
            string? id,
            bool? example,
            global::System.Collections.Generic.IList<global::G.ToolCall>? toolCalls,
            global::System.Collections.Generic.IList<global::G.InvalidToolCall>? invalidToolCalls,
            global::G.UsageMetadata? usageMetadata,
            global::System.Collections.Generic.IList<global::G.ToolCallChunk>? toolCallChunks)
        {
            this.Content = content;
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Name = name;
            this.Id = id;
            this.Example = example;
            this.ToolCalls = toolCalls;
            this.InvalidToolCalls = invalidToolCalls;
            this.UsageMetadata = usageMetadata;
            this.ToolCallChunks = toolCallChunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIMessageChunk" /> class.
        /// </summary>
        public AIMessageChunk()
        {
        }
    }
}
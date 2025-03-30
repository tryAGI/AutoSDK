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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_kwargs")]
        public object? AdditionalKwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_metadata")]
        public object? ResponseMetadata { get; set; }

        /// <summary>
        /// Default Value: AIMessageChunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AIMessageChunkTypeJsonConverter))]
        public global::G.AIMessageChunkType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example")]
        public bool? Example { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_tool_calls")]
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
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_metadata")]
        public global::G.UsageMetadata? UsageMetadata { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_chunks")]
        public global::System.Collections.Generic.IList<global::G.ToolCallChunk>? ToolCallChunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
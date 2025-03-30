//HintName: G.Models.ToolCallChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A chunk of a tool call (e.g., as part of a stream).<br/>
    /// When merging ToolCallChunks (e.g., via AIMessageChunk.__add__),<br/>
    /// all string attributes are concatenated. Chunks are only merged if their<br/>
    /// values of `index` are equal and not None.<br/>
    /// Example:<br/>
    /// .. code-block:: python<br/>
    ///     left_chunks = [ToolCallChunk(name="foo", args='{"a":', index=0)]<br/>
    ///     right_chunks = [ToolCallChunk(name=None, args='1}', index=0)]<br/>
    ///     (<br/>
    ///         AIMessageChunk(content="", tool_call_chunks=left_chunks)<br/>
    ///         + AIMessageChunk(content="", tool_call_chunks=right_chunks)<br/>
    ///     ).tool_call_chunks == [ToolCallChunk(name='foo', args='{"a":1}', index=0)]
    /// </summary>
    public sealed partial class ToolCallChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolCallChunkTypeJsonConverter))]
        public global::G.ToolCallChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallChunk" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="args"></param>
        /// <param name="id"></param>
        /// <param name="index"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallChunk(
            string? name,
            string? args,
            string? id,
            int? index,
            global::G.ToolCallChunkType? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallChunk" /> class.
        /// </summary>
        public ToolCallChunk()
        {
        }
    }
}
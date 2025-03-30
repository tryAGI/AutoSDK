//HintName: G.Models.ToolMessageChunk.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Tool Message chunk.
    /// </summary>
    public sealed partial class ToolMessageChunk
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
        /// Default Value: ToolMessageChunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolMessageChunkType? Type { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact")]
        public object? Artifact { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ToolMessageChunkStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageChunk" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: ToolMessageChunk
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="toolCallId"></param>
        /// <param name="artifact"></param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        public ToolMessageChunk(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> content,
            string toolCallId,
            object? additionalKwargs,
            object? responseMetadata,
            global::G.ToolMessageChunkType? type,
            string? name,
            string? id,
            object? artifact,
            global::G.ToolMessageChunkStatus? status)
        {
            this.Content = content;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Name = name;
            this.Id = id;
            this.Artifact = artifact;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageChunk" /> class.
        /// </summary>
        public ToolMessageChunk()
        {
        }
    }
}
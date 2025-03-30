//HintName: G.Models.HumanMessageChunk.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Human Message chunk.
    /// </summary>
    public sealed partial class HumanMessageChunk
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
        /// Default Value: HumanMessageChunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.HumanMessageChunkType? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanMessageChunk" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: HumanMessageChunk
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="example">
        /// Default Value: false
        /// </param>
        public HumanMessageChunk(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> content,
            object? additionalKwargs,
            object? responseMetadata,
            global::G.HumanMessageChunkType? type,
            string? name,
            string? id,
            bool? example)
        {
            this.Content = content;
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Name = name;
            this.Id = id;
            this.Example = example;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanMessageChunk" /> class.
        /// </summary>
        public HumanMessageChunk()
        {
        }
    }
}
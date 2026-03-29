//HintName: G.Models.ParsingJobCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating a parsing job.
    /// </summary>
    public sealed partial class ParsingJobCreateParams
    {
        /// <summary>
        /// The ID of the file to parse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The elements to extract from the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("element_types")]
        public global::System.Collections.Generic.IList<global::G.ElementType>? ElementTypes { get; set; }

        /// <summary>
        /// The strategy to use for chunking the content<br/>
        /// Default Value: page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChunkingStrategyJsonConverter))]
        public global::G.ChunkingStrategy? ChunkingStrategy { get; set; }

        /// <summary>
        /// The format of the returned content<br/>
        /// Default Value: markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReturnFormatJsonConverter))]
        public global::G.ReturnFormat? ReturnFormat { get; set; }

        /// <summary>
        /// The strategy to use for OCR<br/>
        /// Default Value: high_quality
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModeJsonConverter))]
        public global::G.Mode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobCreateParams" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to parse
        /// </param>
        /// <param name="elementTypes">
        /// The elements to extract from the document
        /// </param>
        /// <param name="chunkingStrategy">
        /// The strategy to use for chunking the content<br/>
        /// Default Value: page
        /// </param>
        /// <param name="returnFormat">
        /// The format of the returned content<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="mode">
        /// The strategy to use for OCR<br/>
        /// Default Value: high_quality
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParsingJobCreateParams(
            string fileId,
            global::System.Collections.Generic.IList<global::G.ElementType>? elementTypes,
            global::G.ChunkingStrategy? chunkingStrategy,
            global::G.ReturnFormat? returnFormat,
            global::G.Mode? mode)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.ElementTypes = elementTypes;
            this.ChunkingStrategy = chunkingStrategy;
            this.ReturnFormat = returnFormat;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobCreateParams" /> class.
        /// </summary>
        public ParsingJobCreateParams()
        {
        }
    }
}
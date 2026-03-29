//HintName: G.Models.TextContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextContent
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TextContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Citations and references within the text (web citations, file citations, map citations, container file citations).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebAnnotation, global::G.FileAnnotation, global::G.MapAnnotation, global::G.ContainerFileAnnotation>>? Annotations { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thought_signature")]
        public string? ThoughtSignature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="annotations">
        /// Citations and references within the text (web citations, file citations, map citations, container file citations).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="thoughtSignature">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public TextContent(
            string text,
            global::G.TextContentType? type,
            string? id,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.WebAnnotation, global::G.FileAnnotation, global::G.MapAnnotation, global::G.ContainerFileAnnotation>>? annotations,
            string? thoughtSignature)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Id = id;
            this.Annotations = annotations;
            this.ThoughtSignature = thoughtSignature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        public TextContent()
        {
        }
    }
}
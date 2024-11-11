//HintName: G.Models.SourceDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceDocument
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileId", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("highlights", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Highlights { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicUrl")]
        public string? PublicUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceDocument" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="name"></param>
        /// <param name="highlights"></param>
        /// <param name="publicUrl"></param>
        /// <param name="labels"></param>
        public SourceDocument(
            string fileId,
            string name,
            global::System.Collections.Generic.IList<string> highlights,
            string? publicUrl,
            global::System.Collections.Generic.IList<string>? labels)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Highlights = highlights ?? throw new global::System.ArgumentNullException(nameof(highlights));
            this.PublicUrl = publicUrl;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceDocument" /> class.
        /// </summary>
        public SourceDocument()
        {
        }
    }
}
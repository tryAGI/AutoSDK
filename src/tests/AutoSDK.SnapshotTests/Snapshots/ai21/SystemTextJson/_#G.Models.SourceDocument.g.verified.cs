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
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Highlights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicUrl")]
        public string? PublicUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceDocument" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="name"></param>
        /// <param name="highlights"></param>
        /// <param name="publicUrl"></param>
        /// <param name="labels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
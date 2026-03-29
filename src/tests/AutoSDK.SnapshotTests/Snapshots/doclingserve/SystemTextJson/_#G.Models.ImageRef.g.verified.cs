//HintName: G.Models.ImageRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ImageRef.
    /// </summary>
    public sealed partial class ImageRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mimetype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Dpi { get; set; }

        /// <summary>
        /// Size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Size Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRef" /> class.
        /// </summary>
        /// <param name="mimetype"></param>
        /// <param name="dpi"></param>
        /// <param name="size">
        /// Size.
        /// </param>
        /// <param name="uri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageRef(
            string mimetype,
            int dpi,
            global::G.Size size,
            string uri)
        {
            this.Mimetype = mimetype ?? throw new global::System.ArgumentNullException(nameof(mimetype));
            this.Dpi = dpi;
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRef" /> class.
        /// </summary>
        public ImageRef()
        {
        }
    }
}
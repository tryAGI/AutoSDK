//HintName: G.Models.DocumentOrigin.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// FileSource.
    /// </summary>
    public sealed partial class DocumentOrigin
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
        [global::System.Text.Json.Serialization.JsonPropertyName("binary_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BinaryHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentOrigin" /> class.
        /// </summary>
        /// <param name="mimetype"></param>
        /// <param name="binaryHash"></param>
        /// <param name="filename"></param>
        /// <param name="uri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentOrigin(
            string mimetype,
            int binaryHash,
            string filename,
            string? uri)
        {
            this.Mimetype = mimetype ?? throw new global::System.ArgumentNullException(nameof(mimetype));
            this.BinaryHash = binaryHash;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentOrigin" /> class.
        /// </summary>
        public DocumentOrigin()
        {
        }
    }
}
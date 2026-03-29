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
        [global::Newtonsoft.Json.JsonProperty("mimetype", Required = global::Newtonsoft.Json.Required.Always)]
        public string Mimetype { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("binary_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public int BinaryHash { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentOrigin" /> class.
        /// </summary>
        /// <param name="mimetype"></param>
        /// <param name="binaryHash"></param>
        /// <param name="filename"></param>
        /// <param name="uri"></param>
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
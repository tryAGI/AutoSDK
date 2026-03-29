//HintName: G.Models.FileSourceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileSourceRequest
    {
        /// <summary>
        /// Content of the file serialized in base64. For example it can be obtained via `base64 -w 0 /path/to/file/pdf-to-convert.pdf`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base64_string", Required = global::Newtonsoft.Json.Required.Always)]
        public string Base64String { get; set; } = default!;

        /// <summary>
        /// Filename of the uploaded document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Default Value: file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSourceRequest" /> class.
        /// </summary>
        /// <param name="base64String">
        /// Content of the file serialized in base64. For example it can be obtained via `base64 -w 0 /path/to/file/pdf-to-convert.pdf`.
        /// </param>
        /// <param name="filename">
        /// Filename of the uploaded document
        /// </param>
        /// <param name="kind">
        /// Default Value: file
        /// </param>
        public FileSourceRequest(
            string base64String,
            string filename,
            string? kind)
        {
            this.Base64String = base64String ?? throw new global::System.ArgumentNullException(nameof(base64String));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSourceRequest" /> class.
        /// </summary>
        public FileSourceRequest()
        {
        }
    }
}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("base64_string")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Base64String { get; set; }

        /// <summary>
        /// Filename of the uploaded document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Default Value: file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
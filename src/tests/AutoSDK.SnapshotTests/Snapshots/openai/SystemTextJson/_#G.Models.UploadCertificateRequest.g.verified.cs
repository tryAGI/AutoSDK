//HintName: G.Models.UploadCertificateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadCertificateRequest
    {
        /// <summary>
        /// An optional name for the certificate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The certificate content in PEM format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCertificateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// An optional name for the certificate
        /// </param>
        /// <param name="content">
        /// The certificate content in PEM format
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadCertificateRequest(
            string content,
            string? name)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCertificateRequest" /> class.
        /// </summary>
        public UploadCertificateRequest()
        {
        }
    }
}
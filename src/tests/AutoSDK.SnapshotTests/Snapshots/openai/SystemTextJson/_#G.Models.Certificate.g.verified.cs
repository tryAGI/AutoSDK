//HintName: G.Models.Certificate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual `certificate` uploaded to the organization.
    /// </summary>
    public sealed partial class Certificate
    {
        /// <summary>
        /// The object type.<br/>
        /// - If creating, updating, or getting a specific certificate, the object type is `certificate`.<br/>
        /// - If listing, activating, or deactivating certificates for the organization, the object type is `organization.certificate`.<br/>
        /// - If listing, activating, or deactivating certificates for a project, the object type is `organization.project.certificate`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CertificateObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CertificateObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the certificate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the certificate was uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CertificateCertificateDetails CertificateDetails { get; set; }

        /// <summary>
        /// Whether the certificate is currently active at the specified scope. Not returned when getting details for a specific certificate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.<br/>
        /// - If creating, updating, or getting a specific certificate, the object type is `certificate`.<br/>
        /// - If listing, activating, or deactivating certificates for the organization, the object type is `organization.certificate`.<br/>
        /// - If listing, activating, or deactivating certificates for a project, the object type is `organization.project.certificate`.
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="name">
        /// The name of the certificate.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the certificate was uploaded.
        /// </param>
        /// <param name="certificateDetails"></param>
        /// <param name="active">
        /// Whether the certificate is currently active at the specified scope. Not returned when getting details for a specific certificate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Certificate(
            global::G.CertificateObject @object,
            string id,
            string name,
            global::System.DateTimeOffset createdAt,
            global::G.CertificateCertificateDetails certificateDetails,
            bool? active)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.CertificateDetails = certificateDetails ?? throw new global::System.ArgumentNullException(nameof(certificateDetails));
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate" /> class.
        /// </summary>
        public Certificate()
        {
        }
    }
}
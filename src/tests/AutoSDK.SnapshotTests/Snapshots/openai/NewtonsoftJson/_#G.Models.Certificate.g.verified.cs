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
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CertificateObject Object { get; set; } = default!;

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the certificate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the certificate was uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("certificate_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CertificateCertificateDetails CertificateDetails { get; set; } = default!;

        /// <summary>
        /// Whether the certificate is currently active at the specified scope. Not returned when getting details for a specific certificate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
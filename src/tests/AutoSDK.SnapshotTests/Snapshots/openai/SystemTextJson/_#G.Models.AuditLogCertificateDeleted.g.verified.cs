//HintName: G.Models.AuditLogCertificateDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogCertificateDeleted
    {
        /// <summary>
        /// The certificate ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the certificate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The certificate content in PEM format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate")]
        public string? Certificate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCertificateDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The certificate ID.
        /// </param>
        /// <param name="name">
        /// The name of the certificate.
        /// </param>
        /// <param name="certificate">
        /// The certificate content in PEM format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogCertificateDeleted(
            string? id,
            string? name,
            string? certificate)
        {
            this.Id = id;
            this.Name = name;
            this.Certificate = certificate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCertificateDeleted" /> class.
        /// </summary>
        public AuditLogCertificateDeleted()
        {
        }
    }
}
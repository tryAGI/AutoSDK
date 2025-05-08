//HintName: G.Models.AuditLogCertificatesActivatedCertificate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditLogCertificatesActivatedCertificate
    {
        /// <summary>
        /// The certificate ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the certificate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCertificatesActivatedCertificate" /> class.
        /// </summary>
        /// <param name="id">
        /// The certificate ID.
        /// </param>
        /// <param name="name">
        /// The name of the certificate.
        /// </param>
        public AuditLogCertificatesActivatedCertificate(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCertificatesActivatedCertificate" /> class.
        /// </summary>
        public AuditLogCertificatesActivatedCertificate()
        {
        }
    }
}
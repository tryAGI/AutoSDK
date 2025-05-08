//HintName: G.Models.AuditLogCertificatesDeactivated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogCertificatesDeactivated
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificates")]
        public global::System.Collections.Generic.IList<global::G.AuditLogCertificatesDeactivatedCertificate>? Certificates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCertificatesDeactivated" /> class.
        /// </summary>
        /// <param name="certificates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogCertificatesDeactivated(
            global::System.Collections.Generic.IList<global::G.AuditLogCertificatesDeactivatedCertificate>? certificates)
        {
            this.Certificates = certificates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCertificatesDeactivated" /> class.
        /// </summary>
        public AuditLogCertificatesDeactivated()
        {
        }
    }
}
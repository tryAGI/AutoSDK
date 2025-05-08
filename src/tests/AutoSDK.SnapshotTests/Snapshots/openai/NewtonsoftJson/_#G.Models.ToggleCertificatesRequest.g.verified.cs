//HintName: G.Models.ToggleCertificatesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToggleCertificatesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("certificate_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> CertificateIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleCertificatesRequest" /> class.
        /// </summary>
        /// <param name="certificateIds"></param>
        public ToggleCertificatesRequest(
            global::System.Collections.Generic.IList<string> certificateIds)
        {
            this.CertificateIds = certificateIds ?? throw new global::System.ArgumentNullException(nameof(certificateIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleCertificatesRequest" /> class.
        /// </summary>
        public ToggleCertificatesRequest()
        {
        }
    }
}
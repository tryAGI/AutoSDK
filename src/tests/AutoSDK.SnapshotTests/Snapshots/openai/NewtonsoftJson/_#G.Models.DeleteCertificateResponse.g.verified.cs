//HintName: G.Models.DeleteCertificateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteCertificateResponse
    {
        /// <summary>
        /// The object type, must be `certificate.deleted`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.DeleteCertificateResponseObject Object { get; set; }

        /// <summary>
        /// The ID of the certificate that was deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCertificateResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, must be `certificate.deleted`.
        /// </param>
        /// <param name="id">
        /// The ID of the certificate that was deleted.
        /// </param>
        public DeleteCertificateResponse(
            string id,
            global::G.DeleteCertificateResponseObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCertificateResponse" /> class.
        /// </summary>
        public DeleteCertificateResponse()
        {
        }
    }
}
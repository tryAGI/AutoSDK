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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeleteCertificateResponseObjectJsonConverter))]
        public global::G.DeleteCertificateResponseObject Object { get; set; }

        /// <summary>
        /// The ID of the certificate that was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
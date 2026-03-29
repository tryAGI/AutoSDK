//HintName: G.Models.UploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response returned by the Ingest API [direct upload](#direct-upload) request. Includes the id of the file and the signed url to send the binary file to. The response follows the [json:api](https://jsonapi.org/) specification.
    /// </summary>
    public sealed partial class UploadResponse
    {
        /// <summary>
        /// The type of resource (an upload), it's id and attributes of the upload request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UploadResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The type of resource (an upload), it's id and attributes of the upload request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadResponse(
            global::G.UploadResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponse" /> class.
        /// </summary>
        public UploadResponse()
        {
        }
    }
}
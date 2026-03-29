//HintName: G.Models.HeliconeDatasetRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeliconeDatasetRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin_request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginRequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResultStringStringJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResultStringString SignedUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeDatasetRow" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="originRequestId"></param>
        /// <param name="datasetId"></param>
        /// <param name="createdAt"></param>
        /// <param name="signedUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeliconeDatasetRow(
            string id,
            string originRequestId,
            string datasetId,
            string createdAt,
            global::G.ResultStringString signedUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OriginRequestId = originRequestId ?? throw new global::System.ArgumentNullException(nameof(originRequestId));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.SignedUrl = signedUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeDatasetRow" /> class.
        /// </summary>
        public HeliconeDatasetRow()
        {
        }
    }
}
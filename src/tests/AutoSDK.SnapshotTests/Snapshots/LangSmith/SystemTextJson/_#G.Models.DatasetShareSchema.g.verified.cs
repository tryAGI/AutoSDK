//HintName: G.Models.DatasetShareSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetShareSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ShareToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetShareSchema" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="shareToken"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DatasetShareSchema(
            global::System.Guid datasetId,
            global::System.Guid shareToken)
        {
            this.DatasetId = datasetId;
            this.ShareToken = shareToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetShareSchema" /> class.
        /// </summary>
        public DatasetShareSchema()
        {
        }
    }
}
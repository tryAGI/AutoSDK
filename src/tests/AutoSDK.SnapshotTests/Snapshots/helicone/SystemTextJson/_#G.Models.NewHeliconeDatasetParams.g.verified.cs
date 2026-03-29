//HintName: G.Models.NewHeliconeDatasetParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewHeliconeDatasetParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequestIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.HeliconeDatasetMetadata? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewHeliconeDatasetParams" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="requestIds"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewHeliconeDatasetParams(
            string datasetName,
            global::System.Collections.Generic.IList<string> requestIds,
            global::G.HeliconeDatasetMetadata? meta)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.RequestIds = requestIds ?? throw new global::System.ArgumentNullException(nameof(requestIds));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewHeliconeDatasetParams" /> class.
        /// </summary>
        public NewHeliconeDatasetParams()
        {
        }
    }
}
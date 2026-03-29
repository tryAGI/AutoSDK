//HintName: G.Models.CreateDatasetItemsFromCsvRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetItemsFromCsvRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromCsvRequest" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="datasetId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetItemsFromCsvRequest(
            object file,
            global::System.Guid datasetId)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromCsvRequest" /> class.
        /// </summary>
        public CreateDatasetItemsFromCsvRequest()
        {
        }
    }
}
//HintName: G.Models.CreateDatasetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetResponse
    {
        /// <summary>
        /// columns and relationships of "datasets"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert_datasets_one")]
        public global::G.CreateDatasetResponseInsertDatasetsOne? InsertDatasetsOne { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetResponse" /> class.
        /// </summary>
        /// <param name="insertDatasetsOne">
        /// columns and relationships of "datasets"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateDatasetResponse(
            global::G.CreateDatasetResponseInsertDatasetsOne? insertDatasetsOne)
        {
            this.InsertDatasetsOne = insertDatasetsOne;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetResponse" /> class.
        /// </summary>
        public CreateDatasetResponse()
        {
        }
    }
}
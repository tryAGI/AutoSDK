//HintName: G.Models.PatchedDatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedDatasetRequest
    {
        /// <summary>
        /// All data columns found in Dataset tasks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columns")]
        public object? Columns { get; set; }

        /// <summary>
        /// User who created Dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimpleRequest? CreatedBy { get; set; }

        /// <summary>
        /// Dataset description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Dataset title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_entities")]
        public int? TotalEntities { get; set; }

        /// <summary>
        /// Dataset name for weaviate schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_db_dataset_name")]
        public string? VectorDbDatasetName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDatasetRequest" /> class.
        /// </summary>
        /// <param name="columns">
        /// All data columns found in Dataset tasks
        /// </param>
        /// <param name="createdBy">
        /// User who created Dataset
        /// </param>
        /// <param name="description">
        /// Dataset description
        /// </param>
        /// <param name="organization"></param>
        /// <param name="title">
        /// Dataset title
        /// </param>
        /// <param name="totalEntities"></param>
        /// <param name="vectorDbDatasetName">
        /// Dataset name for weaviate schema
        /// </param>
        public PatchedDatasetRequest(
            object? columns,
            global::G.UserSimpleRequest? createdBy,
            string? description,
            int? organization,
            string? title,
            int? totalEntities,
            string? vectorDbDatasetName)
        {
            this.Columns = columns;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Organization = organization;
            this.Title = title;
            this.TotalEntities = totalEntities;
            this.VectorDbDatasetName = vectorDbDatasetName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDatasetRequest" /> class.
        /// </summary>
        public PatchedDatasetRequest()
        {
        }
    }
}
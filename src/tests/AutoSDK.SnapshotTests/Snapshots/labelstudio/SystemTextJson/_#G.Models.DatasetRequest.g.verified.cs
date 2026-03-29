//HintName: G.Models.DatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetRequest
    {
        /// <summary>
        /// All data columns found in Dataset tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public object? Columns { get; set; }

        /// <summary>
        /// User who created Dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::G.UserSimpleRequest? CreatedBy { get; set; }

        /// <summary>
        /// Dataset description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Dataset title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_entities")]
        public int? TotalEntities { get; set; }

        /// <summary>
        /// Dataset name for weaviate schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_db_dataset_name")]
        public string? VectorDbDatasetName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// Dataset title
        /// </param>
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
        /// <param name="totalEntities"></param>
        /// <param name="vectorDbDatasetName">
        /// Dataset name for weaviate schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetRequest(
            string title,
            object? columns,
            global::G.UserSimpleRequest? createdBy,
            string? description,
            int? organization,
            int? totalEntities,
            string? vectorDbDatasetName)
        {
            this.Columns = columns;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Organization = organization;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.TotalEntities = totalEntities;
            this.VectorDbDatasetName = vectorDbDatasetName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRequest" /> class.
        /// </summary>
        public DatasetRequest()
        {
        }
    }
}
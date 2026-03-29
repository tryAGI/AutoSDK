//HintName: G.Models.Dataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// All data columns found in Dataset tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public object? Columns { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// User who created Dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::G.UserSimple? CreatedBy { get; set; }

        /// <summary>
        /// Dataset description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

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
        /// Last updated time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="Dataset" /> class.
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
        /// <param name="createdAt">
        /// Creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Last updated time<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            string title,
            object? columns,
            global::G.UserSimple? createdBy,
            string? description,
            int? organization,
            int? totalEntities,
            string? vectorDbDatasetName,
            global::System.DateTime createdAt = default!,
            int id = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Columns = columns;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Id = id;
            this.Organization = organization;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.TotalEntities = totalEntities;
            this.UpdatedAt = updatedAt;
            this.VectorDbDatasetName = vectorDbDatasetName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}
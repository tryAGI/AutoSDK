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
        [global::Newtonsoft.Json.JsonProperty("columns")]
        public object? Columns { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// User who created Dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimple? CreatedBy { get; set; }

        /// <summary>
        /// Dataset description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Dataset title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_entities")]
        public int? TotalEntities { get; set; }

        /// <summary>
        /// Last updated time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

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
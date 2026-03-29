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
        /// Unique identifier for the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the project that the dataset belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Name of the dataset. Within a project, dataset names are unique
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Date of dataset creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date of dataset deletion, or null if the dataset is still active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Identifies the user who created the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// User-controlled metadata about the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// URL slug for the dataset. used to construct dataset URLs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string UrlSlug { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the dataset
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the dataset belongs under
        /// </param>
        /// <param name="name">
        /// Name of the dataset. Within a project, dataset names are unique
        /// </param>
        /// <param name="urlSlug">
        /// URL slug for the dataset. used to construct dataset URLs
        /// </param>
        /// <param name="description">
        /// Textual description of the dataset
        /// </param>
        /// <param name="created">
        /// Date of dataset creation
        /// </param>
        /// <param name="deletedAt">
        /// Date of dataset deletion, or null if the dataset is still active
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the dataset
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the dataset
        /// </param>
        public Dataset(
            global::System.Guid id,
            global::System.Guid projectId,
            string name,
            string urlSlug,
            string? description,
            global::System.DateTime? created,
            global::System.DateTime? deletedAt,
            global::System.Guid? userId,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Created = created;
            this.DeletedAt = deletedAt;
            this.UserId = userId;
            this.Metadata = metadata;
            this.UrlSlug = urlSlug ?? throw new global::System.ArgumentNullException(nameof(urlSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}
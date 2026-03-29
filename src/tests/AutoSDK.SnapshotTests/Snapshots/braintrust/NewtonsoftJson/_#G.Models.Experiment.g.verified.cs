//HintName: G.Models.Experiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Experiment
    {
        /// <summary>
        /// Unique identifier for the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the project that the experiment belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Name of the experiment. Within a project, experiment names are unique
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Date of experiment creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Metadata about the state of the repo when the experiment was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_info")]
        public global::G.RepoInfo? RepoInfo { get; set; }

        /// <summary>
        /// Commit, taken directly from `repo_info.commit`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// Id of default base experiment to compare against when viewing this experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_exp_id")]
        public global::System.Guid? BaseExpId { get; set; }

        /// <summary>
        /// Date of experiment deletion, or null if the experiment is still active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Identifier of the linked dataset, or null if the experiment is not linked to a dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Version number of the linked dataset the experiment was run against. This can be used to reproduce the experiment after the dataset has been modified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_version")]
        public string? DatasetVersion { get; set; }

        /// <summary>
        /// Whether or not the experiment is public. Public experiments can be viewed by anybody inside or outside the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// Identifies the user who created the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// User-controlled metadata about the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// A list of tags for the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the experiment
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the experiment belongs under
        /// </param>
        /// <param name="name">
        /// Name of the experiment. Within a project, experiment names are unique
        /// </param>
        /// <param name="public">
        /// Whether or not the experiment is public. Public experiments can be viewed by anybody inside or outside the organization
        /// </param>
        /// <param name="description">
        /// Textual description of the experiment
        /// </param>
        /// <param name="created">
        /// Date of experiment creation
        /// </param>
        /// <param name="repoInfo">
        /// Metadata about the state of the repo when the experiment was created
        /// </param>
        /// <param name="commit">
        /// Commit, taken directly from `repo_info.commit`
        /// </param>
        /// <param name="baseExpId">
        /// Id of default base experiment to compare against when viewing this experiment
        /// </param>
        /// <param name="deletedAt">
        /// Date of experiment deletion, or null if the experiment is still active
        /// </param>
        /// <param name="datasetId">
        /// Identifier of the linked dataset, or null if the experiment is not linked to a dataset
        /// </param>
        /// <param name="datasetVersion">
        /// Version number of the linked dataset the experiment was run against. This can be used to reproduce the experiment after the dataset has been modified.
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the experiment
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the experiment
        /// </param>
        /// <param name="tags">
        /// A list of tags for the experiment
        /// </param>
        public Experiment(
            global::System.Guid id,
            global::System.Guid projectId,
            string name,
            bool @public,
            string? description,
            global::System.DateTime? created,
            global::G.RepoInfo? repoInfo,
            string? commit,
            global::System.Guid? baseExpId,
            global::System.DateTime? deletedAt,
            global::System.Guid? datasetId,
            string? datasetVersion,
            global::System.Guid? userId,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Created = created;
            this.RepoInfo = repoInfo;
            this.Commit = commit;
            this.BaseExpId = baseExpId;
            this.DeletedAt = deletedAt;
            this.DatasetId = datasetId;
            this.DatasetVersion = datasetVersion;
            this.Public = @public;
            this.UserId = userId;
            this.Metadata = metadata;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        public Experiment()
        {
        }
    }
}
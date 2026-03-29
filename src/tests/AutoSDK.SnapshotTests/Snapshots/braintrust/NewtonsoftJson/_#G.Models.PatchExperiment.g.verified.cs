//HintName: G.Models.PatchExperiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchExperiment
    {
        /// <summary>
        /// Name of the experiment. Within a project, experiment names are unique
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Metadata about the state of the repo when the experiment was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_info")]
        public global::G.RepoInfo? RepoInfo { get; set; }

        /// <summary>
        /// Id of default base experiment to compare against when viewing this experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_exp_id")]
        public global::System.Guid? BaseExpId { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("public")]
        public bool? Public { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchExperiment" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the experiment. Within a project, experiment names are unique
        /// </param>
        /// <param name="description">
        /// Textual description of the experiment
        /// </param>
        /// <param name="repoInfo">
        /// Metadata about the state of the repo when the experiment was created
        /// </param>
        /// <param name="baseExpId">
        /// Id of default base experiment to compare against when viewing this experiment
        /// </param>
        /// <param name="datasetId">
        /// Identifier of the linked dataset, or null if the experiment is not linked to a dataset
        /// </param>
        /// <param name="datasetVersion">
        /// Version number of the linked dataset the experiment was run against. This can be used to reproduce the experiment after the dataset has been modified.
        /// </param>
        /// <param name="public">
        /// Whether or not the experiment is public. Public experiments can be viewed by anybody inside or outside the organization
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the experiment
        /// </param>
        /// <param name="tags">
        /// A list of tags for the experiment
        /// </param>
        public PatchExperiment(
            string? name,
            string? description,
            global::G.RepoInfo? repoInfo,
            global::System.Guid? baseExpId,
            global::System.Guid? datasetId,
            string? datasetVersion,
            bool? @public,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name;
            this.Description = description;
            this.RepoInfo = repoInfo;
            this.BaseExpId = baseExpId;
            this.DatasetId = datasetId;
            this.DatasetVersion = datasetVersion;
            this.Public = @public;
            this.Metadata = metadata;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchExperiment" /> class.
        /// </summary>
        public PatchExperiment()
        {
        }
    }
}
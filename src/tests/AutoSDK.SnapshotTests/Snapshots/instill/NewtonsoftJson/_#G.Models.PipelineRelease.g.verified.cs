//HintName: G.Models.PipelineRelease.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pipeline releases contain the version control information of a pipeline.<br/>
    /// This allows users to track changes in the pipeline over time.
    /// </summary>
    public sealed partial class PipelineRelease
    {
        /// <summary>
        /// The name of the release, defined by its parent and ID.<br/>
        /// - Format: `{parent_type}/{parent.id}/pipelines/{pipeline.id}/releases/{release.id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Release UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Release resource ID (used in `name` as the last segment). It must be a<br/>
        /// sematic version vX.Y.Z.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Release description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Recipe of the versioned pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recipe")]
        public object? Recipe { get; set; }

        /// <summary>
        /// Pipeline creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Pipeline update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Pipeline deletion time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Alias.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Key-value object with console-related data such as the pipeline builder<br/>
        /// layout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// README.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Data specifications.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataSpecification")]
        public global::G.DataSpecification? DataSpecification { get; set; }

        /// <summary>
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rawRecipe")]
        public string? RawRecipe { get; set; }

        /// <summary>
        /// Pipeline endpoints.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoints")]
        public global::G.Endpoints? Endpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRelease" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the release, defined by its parent and ID.<br/>
        /// - Format: `{parent_type}/{parent.id}/pipelines/{pipeline.id}/releases/{release.id}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="uid">
        /// Release UUID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Release resource ID (used in `name` as the last segment). It must be a<br/>
        /// sematic version vX.Y.Z.
        /// </param>
        /// <param name="description">
        /// Release description.
        /// </param>
        /// <param name="recipe">
        /// Recipe of the versioned pipeline.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Pipeline creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Pipeline update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deleteTime">
        /// Pipeline deletion time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="alias">
        /// Alias.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="metadata">
        /// Key-value object with console-related data such as the pipeline builder<br/>
        /// layout.
        /// </param>
        /// <param name="readme">
        /// README.
        /// </param>
        /// <param name="dataSpecification">
        /// Data specifications.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="rawRecipe">
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </param>
        /// <param name="endpoints">
        /// Pipeline endpoints.<br/>
        /// Included only in responses
        /// </param>
        public PipelineRelease(
            string? name,
            string? uid,
            string? id,
            string? description,
            object? recipe,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.DateTime? deleteTime,
            string? alias,
            object? metadata,
            string? readme,
            global::G.DataSpecification? dataSpecification,
            string? rawRecipe,
            global::G.Endpoints? endpoints)
        {
            this.Name = name;
            this.Uid = uid;
            this.Id = id;
            this.Description = description;
            this.Recipe = recipe;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.DeleteTime = deleteTime;
            this.Alias = alias;
            this.Metadata = metadata;
            this.Readme = readme;
            this.DataSpecification = dataSpecification;
            this.RawRecipe = rawRecipe;
            this.Endpoints = endpoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRelease" /> class.
        /// </summary>
        public PipelineRelease()
        {
        }
    }
}
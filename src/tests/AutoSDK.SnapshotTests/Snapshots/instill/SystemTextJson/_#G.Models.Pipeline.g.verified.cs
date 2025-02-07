//HintName: G.Models.Pipeline.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Pipeline is an end-to-end workflow that automates a sequence of components<br/>
    /// to process data.<br/>
    /// For more information, see [Pipeline](https://www.instill.tech/docs/vdp/introduction) in<br/>
    /// the official documentation.
    /// </summary>
    public sealed partial class Pipeline
    {
        /// <summary>
        /// The name of the pipeline, defined by its parent and ID.<br/>
        /// - Format: `{parent_type}/{parent.id}/pipelines/{pipeline.id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Pipeline UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Pipeline resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Pipeline description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Recipe describes the components of a Pipeline and how they are connected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Recipe { get; set; }

        /// <summary>
        /// Pipeline creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Pipeline update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Pipeline delete time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Pipeline sharing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        public global::G.Sharing? Sharing { get; set; }

        /// <summary>
        /// Metadata holds console-related data such as the pipeline builder layout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Owner Name.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// Releases holds the history of pipeline versions.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases")]
        public global::System.Collections.Generic.IList<global::G.PipelineRelease>? Releases { get; set; }

        /// <summary>
        /// README holds the pipeline documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Permission defines how a pipeline can be used.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::G.PipelineV1betaPermission? Permission { get; set; }

        /// <summary>
        /// Pipeline visibility.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PipelineVisibilityJsonConverter))]
        public global::G.PipelineVisibility? Visibility { get; set; }

        /// <summary>
        /// Pipeline owner.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::G.Owner? Owner { get; set; }

        /// <summary>
        /// Data specifications.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSpecification")]
        public global::G.DataSpecification? DataSpecification { get; set; }

        /// <summary>
        /// Tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Statistic data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::G.PipelineStats? Stats { get; set; }

        /// <summary>
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawRecipe")]
        public string? RawRecipe { get; set; }

        /// <summary>
        /// A link to the source code of the pipeline (e.g. to a GitHub repository).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// A link to any extra information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// License under which the pipeline is distributed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Pipeline profile image in base64 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileImage")]
        public string? ProfileImage { get; set; }

        /// <summary>
        /// Pipeline endpoints.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        public global::G.Endpoints? Endpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the pipeline, defined by its parent and ID.<br/>
        /// - Format: `{parent_type}/{parent.id}/pipelines/{pipeline.id}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="uid">
        /// Pipeline UUID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Pipeline resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </param>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="recipe">
        /// Recipe describes the components of a Pipeline and how they are connected.
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
        /// Pipeline delete time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="metadata">
        /// Metadata holds console-related data such as the pipeline builder layout.
        /// </param>
        /// <param name="ownerName">
        /// Owner Name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="releases">
        /// Releases holds the history of pipeline versions.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="readme">
        /// README holds the pipeline documentation.
        /// </param>
        /// <param name="permission">
        /// Permission defines how a pipeline can be used.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="visibility">
        /// Pipeline visibility.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Pipeline owner.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dataSpecification">
        /// Data specifications.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// Tags.
        /// </param>
        /// <param name="stats">
        /// Statistic data.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="rawRecipe">
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the pipeline (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the pipeline is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Pipeline profile image in base64 format.
        /// </param>
        /// <param name="endpoints">
        /// Pipeline endpoints.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pipeline(
            object recipe,
            string? name,
            string? uid,
            string? id,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.DateTime? deleteTime,
            global::G.Sharing? sharing,
            object? metadata,
            string? ownerName,
            global::System.Collections.Generic.IList<global::G.PipelineRelease>? releases,
            string? readme,
            global::G.PipelineV1betaPermission? permission,
            global::G.PipelineVisibility? visibility,
            global::G.Owner? owner,
            global::G.DataSpecification? dataSpecification,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.PipelineStats? stats,
            string? rawRecipe,
            string? sourceUrl,
            string? documentationUrl,
            string? license,
            string? profileImage,
            global::G.Endpoints? endpoints)
        {
            this.Recipe = recipe ?? throw new global::System.ArgumentNullException(nameof(recipe));
            this.Name = name;
            this.Uid = uid;
            this.Id = id;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.DeleteTime = deleteTime;
            this.Sharing = sharing;
            this.Metadata = metadata;
            this.OwnerName = ownerName;
            this.Releases = releases;
            this.Readme = readme;
            this.Permission = permission;
            this.Visibility = visibility;
            this.Owner = owner;
            this.DataSpecification = dataSpecification;
            this.Tags = tags;
            this.Stats = stats;
            this.RawRecipe = rawRecipe;
            this.SourceUrl = sourceUrl;
            this.DocumentationUrl = documentationUrl;
            this.License = license;
            this.ProfileImage = profileImage;
            this.Endpoints = endpoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline" /> class.
        /// </summary>
        public Pipeline()
        {
        }
    }
}
//HintName: G.Models.DatasetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for a Dataset.
    /// </summary>
    public sealed partial class DatasetResponse
    {
        /// <summary>
        /// Path of the Dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the Dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directoryId")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// Name of the Dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Unique identifier for the specific Dataset Version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DatasetResponseType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environments")]
        public global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdBy")]
        public global::G.UserResponse? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUsedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// The number of Datapoints in this Dataset version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datapointsCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatapointsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datapoints")]
        public global::System.Collections.Generic.IList<global::G.DatapointResponse>? Datapoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetResponse" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the Dataset.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the Dataset.
        /// </param>
        /// <param name="name">
        /// Name of the Dataset.
        /// </param>
        /// <param name="versionId">
        /// Unique identifier for the specific Dataset Version.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="datapointsCount">
        /// The number of Datapoints in this Dataset version.
        /// </param>
        /// <param name="directoryId"></param>
        /// <param name="description"></param>
        /// <param name="schema"></param>
        /// <param name="readme"></param>
        /// <param name="tags"></param>
        /// <param name="type"></param>
        /// <param name="environments"></param>
        /// <param name="createdBy"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="datapoints"></param>
        /// <param name="attributes"></param>
        public DatasetResponse(
            string path,
            string id,
            string name,
            string versionId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime lastUsedAt,
            int datapointsCount,
            string? directoryId,
            string? description,
            object? schema,
            string? readme,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.DatasetResponseType? type,
            global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? environments,
            global::G.UserResponse? createdBy,
            string? versionName,
            string? versionDescription,
            global::System.Collections.Generic.IList<global::G.DatapointResponse>? datapoints,
            object? attributes)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DirectoryId = directoryId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Schema = schema;
            this.Readme = readme;
            this.Tags = tags;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Type = type;
            this.Environments = environments;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.LastUsedAt = lastUsedAt;
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.DatapointsCount = datapointsCount;
            this.Datapoints = datapoints;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetResponse" /> class.
        /// </summary>
        public DatasetResponse()
        {
        }
    }
}
//HintName: G.Models.Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// The resource name of the model, which allows its access by owner and ID.<br/>
        /// - Format: `users/{user.id}/models/{model.id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Model UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Model resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Model description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The model definition that has been used to import the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelDefinition", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelDefinition { get; set; } = default!;

        /// <summary>
        /// Model configuration. This field is validated against the model<br/>
        /// specification in the model definition (i.e. the `model_spec` field in the<br/>
        /// model definition).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration", Required = global::Newtonsoft.Json.Required.Always)]
        public object Configuration { get; set; } = default!;

        /// <summary>
        /// Model task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AITask Task { get; set; } = default!;

        /// <summary>
        /// Model visibility.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// Model creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Model update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Model deletion time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Resource name of the owner.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// Model owner.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public global::G.Owner? Owner { get; set; }

        /// <summary>
        /// Region of choice for the particular provider to host the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public string Region { get; set; } = default!;

        /// <summary>
        /// Hardware of choice to serve the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hardware", Required = global::Newtonsoft.Json.Required.Always)]
        public string Hardware { get; set; } = default!;

        /// <summary>
        /// README holds the model documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// A link to the source code of the model (e.g. to a GitHub repository).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// A link to any extra information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// License under which the model is distributed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license")]
        public string? License { get; set; }

        /// <summary>
        /// Model profile image in base64 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profileImage")]
        public string? ProfileImage { get; set; }

        /// <summary>
        /// Permission defines how a pipeline can be used.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public global::G.Permission? Permission { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputSchema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Tags.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Version names.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versions")]
        public global::System.Collections.Generic.IList<string>? Versions { get; set; }

        /// <summary>
        /// Statistic data.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats")]
        public global::G.ModelStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="name">
        /// The resource name of the model, which allows its access by owner and ID.<br/>
        /// - Format: `users/{user.id}/models/{model.id}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="uid">
        /// Model UUID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Model resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.
        /// </param>
        /// <param name="description">
        /// Model description.
        /// </param>
        /// <param name="modelDefinition">
        /// The model definition that has been used to import the model.
        /// </param>
        /// <param name="configuration">
        /// Model configuration. This field is validated against the model<br/>
        /// specification in the model definition (i.e. the `model_spec` field in the<br/>
        /// model definition).
        /// </param>
        /// <param name="task">
        /// Model task.
        /// </param>
        /// <param name="visibility">
        /// Model visibility.
        /// </param>
        /// <param name="createTime">
        /// Model creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Model update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deleteTime">
        /// Model deletion time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="ownerName">
        /// Resource name of the owner.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Model owner.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="region">
        /// Region of choice for the particular provider to host the model.
        /// </param>
        /// <param name="hardware">
        /// Hardware of choice to serve the model.
        /// </param>
        /// <param name="readme">
        /// README holds the model documentation.
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the model (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the model is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Model profile image in base64 format.
        /// </param>
        /// <param name="permission">
        /// Permission defines how a pipeline can be used.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputSchema">
        /// Included only in responses
        /// </param>
        /// <param name="outputSchema">
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// Tags.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="versions">
        /// Version names.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="stats">
        /// Statistic data.<br/>
        /// Included only in responses
        /// </param>
        public Model(
            string id,
            string modelDefinition,
            object configuration,
            global::G.AITask task,
            global::G.ModelVisibility visibility,
            string region,
            string hardware,
            string? name,
            string? uid,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.DateTime? deleteTime,
            string? ownerName,
            global::G.Owner? owner,
            string? readme,
            string? sourceUrl,
            string? documentationUrl,
            string? license,
            string? profileImage,
            global::G.Permission? permission,
            object? inputSchema,
            object? outputSchema,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? versions,
            global::G.ModelStats? stats)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ModelDefinition = modelDefinition ?? throw new global::System.ArgumentNullException(nameof(modelDefinition));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Task = task;
            this.Visibility = visibility;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.Name = name;
            this.Uid = uid;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.DeleteTime = deleteTime;
            this.OwnerName = ownerName;
            this.Owner = owner;
            this.Readme = readme;
            this.SourceUrl = sourceUrl;
            this.DocumentationUrl = documentationUrl;
            this.License = license;
            this.ProfileImage = profileImage;
            this.Permission = permission;
            this.InputSchema = inputSchema;
            this.OutputSchema = outputSchema;
            this.Tags = tags;
            this.Versions = versions;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}
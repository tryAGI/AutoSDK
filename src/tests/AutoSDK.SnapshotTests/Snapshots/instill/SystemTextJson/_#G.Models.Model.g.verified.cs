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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Model UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Model resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Model description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The model definition that has been used to import the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelDefinition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelDefinition { get; set; }

        /// <summary>
        /// Model configuration. This field is validated against the model<br/>
        /// specification in the model definition (i.e. the `model_spec` field in the<br/>
        /// model definition).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Configuration { get; set; }

        /// <summary>
        /// Model task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AITaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AITask Task { get; set; }

        /// <summary>
        /// Model visibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelVisibility Visibility { get; set; }

        /// <summary>
        /// Model creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Model update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Model deletion time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Resource name of the owner.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// Model owner.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::G.Owner? Owner { get; set; }

        /// <summary>
        /// Region of choice for the particular provider to host the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Hardware of choice to serve the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hardware { get; set; }

        /// <summary>
        /// README holds the model documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// A link to the source code of the model (e.g. to a GitHub repository).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// A link to any extra information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// License under which the model is distributed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Model profile image in base64 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileImage")]
        public string? ProfileImage { get; set; }

        /// <summary>
        /// Permission defines how a pipeline can be used.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::G.Permission? Permission { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Tags.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Version names.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<string>? Versions { get; set; }

        /// <summary>
        /// Statistic data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::G.ModelStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.Model? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Model),
                jsonSerializerContext) as global::G.Model;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Model? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Model>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Model?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Model),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Model;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Model?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Model?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
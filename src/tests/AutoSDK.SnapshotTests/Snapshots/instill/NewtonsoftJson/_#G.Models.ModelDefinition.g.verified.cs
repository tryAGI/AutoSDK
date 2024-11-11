//HintName: G.Models.ModelDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ModelDefinition defines how to configure and import a model.
    /// </summary>
    public sealed partial class ModelDefinition
    {
        /// <summary>
        /// The resource name of the model, which allows its access by ID.<br/>
        /// - Format: `model-definitions/{id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Model definition UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Model definition resource ID (used in `name` as the last segment). This<br/>
        /// conforms to RFC-1034, which restricts to letters, numbers, and hyphen,<br/>
        /// with the first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Official display title.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Documentation URL.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// Display icon.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Release stage.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("releaseStage")]
        public global::G.ReleaseStage? ReleaseStage { get; set; }

        /// <summary>
        /// The model specification represented by a JSON schema. It is used to<br/>
        /// validate the JSON configurations of a model created from a specific model<br/>
        /// source, and the resource spec which the model is desired to be deployed on.<br/>
        /// It must be a valid JSON that includes what fields are needed to<br/>
        /// create or display a model.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelSpec")]
        public object? ModelSpec { get; set; }

        /// <summary>
        /// Creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDefinition" /> class.
        /// </summary>
        /// <param name="name">
        /// The resource name of the model, which allows its access by ID.<br/>
        /// - Format: `model-definitions/{id}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="uid">
        /// Model definition UUID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Model definition resource ID (used in `name` as the last segment). This<br/>
        /// conforms to RFC-1034, which restricts to letters, numbers, and hyphen,<br/>
        /// with the first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// Official display title.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="documentationUrl">
        /// Documentation URL.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="icon">
        /// Display icon.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="releaseStage">
        /// Release stage.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="modelSpec">
        /// The model specification represented by a JSON schema. It is used to<br/>
        /// validate the JSON configurations of a model created from a specific model<br/>
        /// source, and the resource spec which the model is desired to be deployed on.<br/>
        /// It must be a valid JSON that includes what fields are needed to<br/>
        /// create or display a model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Update time.<br/>
        /// Included only in responses
        /// </param>
        public ModelDefinition(
            string? name,
            string? uid,
            string? id,
            string? title,
            string? documentationUrl,
            string? icon,
            global::G.ReleaseStage? releaseStage,
            object? modelSpec,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime)
        {
            this.Name = name;
            this.Uid = uid;
            this.Id = id;
            this.Title = title;
            this.DocumentationUrl = documentationUrl;
            this.Icon = icon;
            this.ReleaseStage = releaseStage;
            this.ModelSpec = modelSpec;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDefinition" /> class.
        /// </summary>
        public ModelDefinition()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ModelDefinition? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ModelDefinition>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ModelDefinition?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ModelDefinition?>(serializer.Deserialize<global::G.ModelDefinition>(jsonReader));
        }

    }
}
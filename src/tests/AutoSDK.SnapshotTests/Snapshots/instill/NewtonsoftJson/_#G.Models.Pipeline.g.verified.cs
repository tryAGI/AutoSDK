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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Pipeline UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Pipeline resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Pipeline description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Recipe describes the components of a Pipeline and how they are connected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recipe", Required = global::Newtonsoft.Json.Required.Always)]
        public object Recipe { get; set; } = default!;

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
        /// Pipeline delete time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Pipeline sharing information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sharing")]
        public global::G.Sharing? Sharing { get; set; }

        /// <summary>
        /// Metadata holds console-related data such as the pipeline builder layout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Owner Name.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// Releases holds the history of pipeline versions.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("releases")]
        public global::System.Collections.Generic.IList<global::G.PipelineRelease>? Releases { get; set; }

        /// <summary>
        /// README holds the pipeline documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Permission defines how a pipeline can be used.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public global::G.PipelineV1betaPermission? Permission { get; set; }

        /// <summary>
        /// Pipeline visibility.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        public global::G.PipelineVisibility? Visibility { get; set; }

        /// <summary>
        /// Pipeline owner.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public global::G.Owner? Owner { get; set; }

        /// <summary>
        /// Data specifications.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataSpecification")]
        public global::G.DataSpecification? DataSpecification { get; set; }

        /// <summary>
        /// Tags.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Statistic data.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats")]
        public global::G.PipelineStats? Stats { get; set; }

        /// <summary>
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rawRecipe")]
        public string? RawRecipe { get; set; }

        /// <summary>
        /// A link to the source code of the pipeline (e.g. to a GitHub repository).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// A link to any extra information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// License under which the pipeline is distributed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license")]
        public string? License { get; set; }

        /// <summary>
        /// Pipeline profile image in base64 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profileImage")]
        public string? ProfileImage { get; set; }

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
        public static global::G.Pipeline? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Pipeline>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Pipeline?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Pipeline?>(serializer.Deserialize<global::G.Pipeline>(jsonReader));
        }

    }
}
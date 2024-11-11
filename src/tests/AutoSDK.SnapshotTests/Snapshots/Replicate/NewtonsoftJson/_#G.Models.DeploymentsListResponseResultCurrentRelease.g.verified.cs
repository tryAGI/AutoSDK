//HintName: G.Models.DeploymentsListResponseResultCurrentRelease.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsListResponseResultCurrentRelease
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public global::G.DeploymentsListResponseResultCurrentReleaseConfiguration? Configuration { get; set; }

        /// <summary>
        /// The time the release was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.DeploymentsListResponseResultCurrentReleaseCreatedBy? CreatedBy { get; set; }

        /// <summary>
        /// The model identifier string in the format of `{model_owner}/{model_name}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The release number. This is an auto-incrementing integer that starts at 1, and is set automatically when a deployment is created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number")]
        public int? Number { get; set; }

        /// <summary>
        /// The ID of the model version used in the release.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsListResponseResultCurrentRelease" /> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="createdAt">
        /// The time the release was created.
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="model">
        /// The model identifier string in the format of `{model_owner}/{model_name}`.
        /// </param>
        /// <param name="number">
        /// The release number. This is an auto-incrementing integer that starts at 1, and is set automatically when a deployment is created.
        /// </param>
        /// <param name="version">
        /// The ID of the model version used in the release.
        /// </param>
        public DeploymentsListResponseResultCurrentRelease(
            global::G.DeploymentsListResponseResultCurrentReleaseConfiguration? configuration,
            global::System.DateTime? createdAt,
            global::G.DeploymentsListResponseResultCurrentReleaseCreatedBy? createdBy,
            string? model,
            int? number,
            string? version)
        {
            this.Configuration = configuration;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Model = model;
            this.Number = number;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsListResponseResultCurrentRelease" /> class.
        /// </summary>
        public DeploymentsListResponseResultCurrentRelease()
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
        public static global::G.DeploymentsListResponseResultCurrentRelease? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DeploymentsListResponseResultCurrentRelease>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.DeploymentsListResponseResultCurrentRelease?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DeploymentsListResponseResultCurrentRelease?>(serializer.Deserialize<global::G.DeploymentsListResponseResultCurrentRelease>(jsonReader));
        }

    }
}
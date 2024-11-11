//HintName: G.Models.FTModelCard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extra fields for fine-tuned models.
    /// </summary>
    public sealed partial class FTModelCard
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelCapabilities Capabilities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecation")]
        public global::System.DateTime? Deprecation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job", Required = global::Newtonsoft.Json.Required.Always)]
        public string Job { get; set; } = default!;

        /// <summary>
        /// Default Value: 32768
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_context_length")]
        public int? MaxContextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Default Value: mistralai
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("root", Required = global::Newtonsoft.Json.Required.Always)]
        public string Root { get; set; } = default!;

        /// <summary>
        /// Default Value: fine-tuned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FTModelCardType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FTModelCard" /> class.
        /// </summary>
        /// <param name="aliases">
        /// Default Value: []
        /// </param>
        /// <param name="archived">
        /// Default Value: false
        /// </param>
        /// <param name="capabilities"></param>
        /// <param name="created"></param>
        /// <param name="deprecation"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="job"></param>
        /// <param name="maxContextLength">
        /// Default Value: 32768
        /// </param>
        /// <param name="name"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
        /// <param name="ownedBy">
        /// Default Value: mistralai
        /// </param>
        /// <param name="root"></param>
        /// <param name="type">
        /// Default Value: fine-tuned
        /// </param>
        public FTModelCard(
            global::G.ModelCapabilities capabilities,
            string id,
            string job,
            string root,
            global::System.Collections.Generic.IList<string>? aliases,
            bool? archived,
            int? created,
            global::System.DateTime? deprecation,
            string? description,
            int? maxContextLength,
            string? name,
            string? @object,
            string? ownedBy,
            global::G.FTModelCardType? type)
        {
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.Aliases = aliases;
            this.Archived = archived;
            this.Created = created;
            this.Deprecation = deprecation;
            this.Description = description;
            this.MaxContextLength = maxContextLength;
            this.Name = name;
            this.Object = @object;
            this.OwnedBy = ownedBy;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FTModelCard" /> class.
        /// </summary>
        public FTModelCard()
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
        public static global::G.FTModelCard? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FTModelCard>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.FTModelCard?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.FTModelCard?>(serializer.Deserialize<global::G.FTModelCard>(jsonReader));
        }

    }
}
//HintName: G.Models.CloneNamespacePipelineBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CloneNamespacePipelineRequest represents a request to clone a pipeline owned by a<br/>
    /// user.
    /// </summary>
    public sealed partial class CloneNamespacePipelineBody
    {
        /// <summary>
        /// Pipeline description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Pipeline sharing information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sharing")]
        public global::G.Sharing? Sharing { get; set; }

        /// <summary>
        /// Target Namespace ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("targetNamespaceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetNamespaceId { get; set; } = default!;

        /// <summary>
        /// Target Pipeline ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("targetPipelineId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetPipelineId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneNamespacePipelineBody" /> class.
        /// </summary>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="targetNamespaceId">
        /// Target Namespace ID.
        /// </param>
        /// <param name="targetPipelineId">
        /// Target Pipeline ID.
        /// </param>
        public CloneNamespacePipelineBody(
            string targetNamespaceId,
            string targetPipelineId,
            string? description,
            global::G.Sharing? sharing)
        {
            this.TargetNamespaceId = targetNamespaceId ?? throw new global::System.ArgumentNullException(nameof(targetNamespaceId));
            this.TargetPipelineId = targetPipelineId ?? throw new global::System.ArgumentNullException(nameof(targetPipelineId));
            this.Description = description;
            this.Sharing = sharing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneNamespacePipelineBody" /> class.
        /// </summary>
        public CloneNamespacePipelineBody()
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
        public static global::G.CloneNamespacePipelineBody? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CloneNamespacePipelineBody>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CloneNamespacePipelineBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CloneNamespacePipelineBody?>(serializer.Deserialize<global::G.CloneNamespacePipelineBody>(jsonReader));
        }

    }
}
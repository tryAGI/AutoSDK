//HintName: G.Models.CloneNamespacePipelineReleaseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CloneNamespacePipelineReleaseRequest represents a request to clone a pipeline<br/>
    /// release owned by a user.
    /// </summary>
    public sealed partial class CloneNamespacePipelineReleaseBody
    {
        /// <summary>
        /// Pipeline description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Pipeline sharing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        public global::G.Sharing? Sharing { get; set; }

        /// <summary>
        /// Target Namespace ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetNamespaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNamespaceId { get; set; }

        /// <summary>
        /// Target Pipeline ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetPipelineId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetPipelineId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneNamespacePipelineReleaseBody" /> class.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CloneNamespacePipelineReleaseBody(
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
        /// Initializes a new instance of the <see cref="CloneNamespacePipelineReleaseBody" /> class.
        /// </summary>
        public CloneNamespacePipelineReleaseBody()
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
        public static global::G.CloneNamespacePipelineReleaseBody? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CloneNamespacePipelineReleaseBody),
                jsonSerializerContext) as global::G.CloneNamespacePipelineReleaseBody;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CloneNamespacePipelineReleaseBody? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CloneNamespacePipelineReleaseBody>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CloneNamespacePipelineReleaseBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CloneNamespacePipelineReleaseBody),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CloneNamespacePipelineReleaseBody;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CloneNamespacePipelineReleaseBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CloneNamespacePipelineReleaseBody?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
//HintName: G.Models.MergeGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A group of pull requests that the merge queue has grouped together to be merged.
    /// </summary>
    public sealed partial class MergeGroup
    {
        /// <summary>
        /// The SHA of the merge group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// The full ref of the merge group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadRef { get; set; }

        /// <summary>
        /// The SHA of the merge group's parent commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseSha { get; set; }

        /// <summary>
        /// The full ref of the branch the merge group will be merged into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseRef { get; set; }

        /// <summary>
        /// A commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleCommit HeadCommit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.MergeGroup? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.MergeGroup),
                jsonSerializerContext) as global::G.MergeGroup;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MergeGroup? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.MergeGroup>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.MergeGroup?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.MergeGroup),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.MergeGroup;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.MergeGroup?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.MergeGroup?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
//HintName: G.Models.DiffEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Diff Entry
    /// </summary>
    public sealed partial class DiffEntry
    {
        /// <summary>
        /// Example: bbcd538c8e72b8c175046e27cc8f907076331401
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Example: file1.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Example: added
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DiffEntryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DiffEntryStatus Status { get; set; }

        /// <summary>
        /// Example: 103
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Additions { get; set; }

        /// <summary>
        /// Example: 21
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Deletions { get; set; }

        /// <summary>
        /// Example: 124
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Changes { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/blob/6dcb09b5b57875f334f61aebed695e2e4193db5e/file1.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/raw/6dcb09b5b57875f334f61aebed695e2e4193db5e/file1.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contents/file1.txt?ref=6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentsUrl { get; set; }

        /// <summary>
        /// Example: @@ -132,7 +132,7 @@ module Test @@ -1000,7 +1000,7 @@ module Test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        public string? Patch { get; set; }

        /// <summary>
        /// Example: file.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_filename")]
        public string? PreviousFilename { get; set; }

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
        public static global::G.DiffEntry? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.DiffEntry),
                jsonSerializerContext) as global::G.DiffEntry;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DiffEntry? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.DiffEntry>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.DiffEntry?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.DiffEntry),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.DiffEntry;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.DiffEntry?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.DiffEntry?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
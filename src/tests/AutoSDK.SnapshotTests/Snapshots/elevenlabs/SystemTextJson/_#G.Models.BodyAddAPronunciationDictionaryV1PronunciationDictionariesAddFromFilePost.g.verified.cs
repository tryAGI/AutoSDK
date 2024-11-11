//HintName: G.Models.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost
    {
        /// <summary>
        /// The name of the pronunciation dictionary, used for identification only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// A description of the pronunciation dictionary, used for identification only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Should be one of 'editor' or 'viewer'. If not provided, defaults to no access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessJsonConverter))]
        public global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? WorkspaceAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="file">
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </param>
        /// <param name="filename">
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </param>
        /// <param name="description">
        /// A description of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="workspaceAccess">
        /// Should be one of 'editor' or 'viewer'. If not provided, defaults to no access.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost(
            string name,
            byte[]? file,
            string? filename,
            string? description,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? workspaceAccess)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.File = file;
            this.Filename = filename;
            this.Description = description;
            this.WorkspaceAccess = workspaceAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost" /> class.
        /// </summary>
        public BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost()
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
        public static global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost),
                jsonSerializerContext) as global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
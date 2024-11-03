//HintName: G.Models.CodespaceWithFullRepositoryGitStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about the codespace's git repository.
    /// </summary>
    public sealed partial class CodespaceWithFullRepositoryGitStatus
    {
        /// <summary>
        /// The number of commits the local repository is ahead of the remote.<br/>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ahead")]
        public int? Ahead { get; set; }

        /// <summary>
        /// The number of commits the local repository is behind the remote.<br/>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("behind")]
        public int? Behind { get; set; }

        /// <summary>
        /// Whether the local repository has unpushed changes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_unpushed_changes")]
        public bool? HasUnpushedChanges { get; set; }

        /// <summary>
        /// Whether the local repository has uncommitted changes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_uncommitted_changes")]
        public bool? HasUncommittedChanges { get; set; }

        /// <summary>
        /// The current branch (or SHA if in detached HEAD state) of the local repository.<br/>
        /// Example: main
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

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
        public static global::G.CodespaceWithFullRepositoryGitStatus? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodespaceWithFullRepositoryGitStatus>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CodespaceWithFullRepositoryGitStatus?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodespaceWithFullRepositoryGitStatus?>(serializer.Deserialize<global::G.CodespaceWithFullRepositoryGitStatus>(jsonReader));
        }

    }
}
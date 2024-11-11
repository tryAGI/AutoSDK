//HintName: G.Models.BackupRestoreRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for restoring a backup for a set of classes
    /// </summary>
    public sealed partial class BackupRestoreRequest
    {
        /// <summary>
        /// Backup custom configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.RestoreConfig? Config { get; set; }

        /// <summary>
        /// List of collections to include in the backup restoration process. If not set, all collections are included. Cannot be used together with `exclude`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// List of collections to exclude from the backup restoration process. If not set, all collections are included. Cannot be used together with `include`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Allows overriding the node names stored in the backup with different ones. Useful when restoring backups to a different environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? NodeMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Backup custom configuration
        /// </param>
        /// <param name="include">
        /// List of collections to include in the backup restoration process. If not set, all collections are included. Cannot be used together with `exclude`.
        /// </param>
        /// <param name="exclude">
        /// List of collections to exclude from the backup restoration process. If not set, all collections are included. Cannot be used together with `include`.
        /// </param>
        /// <param name="nodeMapping">
        /// Allows overriding the node names stored in the backup with different ones. Useful when restoring backups to a different environment.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BackupRestoreRequest(
            global::G.RestoreConfig? config,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Collections.Generic.Dictionary<string, string>? nodeMapping)
        {
            this.Config = config;
            this.Include = include;
            this.Exclude = exclude;
            this.NodeMapping = nodeMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreRequest" /> class.
        /// </summary>
        public BackupRestoreRequest()
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
        public static global::G.BackupRestoreRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BackupRestoreRequest),
                jsonSerializerContext) as global::G.BackupRestoreRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BackupRestoreRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BackupRestoreRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.BackupRestoreRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.BackupRestoreRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.BackupRestoreRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.BackupRestoreRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.BackupRestoreRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
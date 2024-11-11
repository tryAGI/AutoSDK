//HintName: G.Models.Snapshot.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a new snapshot of a repository's dependencies.
    /// </summary>
    public sealed partial class Snapshot
    {
        /// <summary>
        /// The version of the repository snapshot submission.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SnapshotJob Job { get; set; } = default!;

        /// <summary>
        /// The commit SHA associated with this dependency snapshot. Maximum length: 40 characters.<br/>
        /// Example: ddc951f4b1293222421f2c8df679786153acf689
        /// </summary>
        /// <example>ddc951f4b1293222421f2c8df679786153acf689</example>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// The repository branch that triggered this snapshot.<br/>
        /// Example: refs/heads/main
        /// </summary>
        /// <example>refs/heads/main</example>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// A description of the detector used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SnapshotDetector Detector { get; set; } = default!;

        /// <summary>
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// A collection of package manifests, which are a collection of related dependencies declared in a file or representing a logical group of dependencies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifests")]
        public global::System.Collections.Generic.Dictionary<string, global::G.Manifest>? Manifests { get; set; }

        /// <summary>
        /// The time at which the snapshot was scanned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scanned", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Scanned { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Snapshot" /> class.
        /// </summary>
        /// <param name="version">
        /// The version of the repository snapshot submission.
        /// </param>
        /// <param name="job"></param>
        /// <param name="sha">
        /// The commit SHA associated with this dependency snapshot. Maximum length: 40 characters.<br/>
        /// Example: ddc951f4b1293222421f2c8df679786153acf689
        /// </param>
        /// <param name="ref">
        /// The repository branch that triggered this snapshot.<br/>
        /// Example: refs/heads/main
        /// </param>
        /// <param name="detector">
        /// A description of the detector used.
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </param>
        /// <param name="manifests">
        /// A collection of package manifests, which are a collection of related dependencies declared in a file or representing a logical group of dependencies.
        /// </param>
        /// <param name="scanned">
        /// The time at which the snapshot was scanned.
        /// </param>
        public Snapshot(
            int version,
            global::G.SnapshotJob job,
            string sha,
            string @ref,
            global::G.SnapshotDetector detector,
            global::System.DateTime scanned,
            object? metadata,
            global::System.Collections.Generic.Dictionary<string, global::G.Manifest>? manifests)
        {
            this.Version = version;
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Detector = detector ?? throw new global::System.ArgumentNullException(nameof(detector));
            this.Scanned = scanned;
            this.Metadata = metadata;
            this.Manifests = manifests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Snapshot" /> class.
        /// </summary>
        public Snapshot()
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
        public static global::G.Snapshot? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Snapshot>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Snapshot?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Snapshot?>(serializer.Deserialize<global::G.Snapshot>(jsonReader));
        }

    }
}
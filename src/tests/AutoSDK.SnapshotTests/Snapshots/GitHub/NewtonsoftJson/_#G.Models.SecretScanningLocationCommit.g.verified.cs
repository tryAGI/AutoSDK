//HintName: G.Models.SecretScanningLocationCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'commit' secret scanning location type. This location type shows that a secret was detected inside a commit to a repository.
    /// </summary>
    public sealed partial class SecretScanningLocationCommit
    {
        /// <summary>
        /// The file path in the repository<br/>
        /// Example: /example/secrets.txt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Line number at which the secret starts in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartLine { get; set; } = default!;

        /// <summary>
        /// Line number at which the secret ends in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_line", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndLine { get; set; } = default!;

        /// <summary>
        /// The column at which the secret starts within the start line when the file is interpreted as 8BIT ASCII
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_column", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartColumn { get; set; } = default!;

        /// <summary>
        /// The column at which the secret ends within the end line when the file is interpreted as 8BIT ASCII
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_column", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndColumn { get; set; } = default!;

        /// <summary>
        /// SHA-1 hash ID of the associated blob<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blob_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobSha { get; set; } = default!;

        /// <summary>
        /// The API URL to get the associated blob resource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blob_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobUrl { get; set; } = default!;

        /// <summary>
        /// SHA-1 hash ID of the associated commit<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitSha { get; set; } = default!;

        /// <summary>
        /// The API URL to get the associated commit resource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
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

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.SecretScanningLocationCommit? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SecretScanningLocationCommit>(
                json,
                jsonSerializerOptions);
        }

    }
}
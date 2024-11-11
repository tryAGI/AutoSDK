//HintName: G.Models.SecretScanningLocationWikiCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'wiki_commit' secret scanning location type. This location type shows that a secret was detected inside a commit to a repository wiki.
    /// </summary>
    public sealed partial class SecretScanningLocationWikiCommit
    {
        /// <summary>
        /// The file path of the wiki page<br/>
        /// Example: /example/Home.md
        /// </summary>
        /// <example>/example/Home.md</example>
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
        /// The column at which the secret starts within the start line when the file is interpreted as 8-bit ASCII.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_column", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartColumn { get; set; } = default!;

        /// <summary>
        /// The column at which the secret ends within the end line when the file is interpreted as 8-bit ASCII.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_column", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndColumn { get; set; } = default!;

        /// <summary>
        /// SHA-1 hash ID of the associated blob<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </summary>
        /// <example>af5626b4a114abcb82d63db7c8082c3c4756e51b</example>
        [global::Newtonsoft.Json.JsonProperty("blob_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobSha { get; set; } = default!;

        /// <summary>
        /// The GitHub URL to get the associated wiki page<br/>
        /// Example: https://github.com/octocat/Hello-World/wiki/Home/302c0b7e200761c9dd9b57e57db540ee0b4293a5
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/wiki/Home/302c0b7e200761c9dd9b57e57db540ee0b4293a5</example>
        [global::Newtonsoft.Json.JsonProperty("page_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PageUrl { get; set; } = default!;

        /// <summary>
        /// SHA-1 hash ID of the associated commit<br/>
        /// Example: 302c0b7e200761c9dd9b57e57db540ee0b4293a5
        /// </summary>
        /// <example>302c0b7e200761c9dd9b57e57db540ee0b4293a5</example>
        [global::Newtonsoft.Json.JsonProperty("commit_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitSha { get; set; } = default!;

        /// <summary>
        /// The GitHub URL to get the associated wiki commit<br/>
        /// Example: https://github.com/octocat/Hello-World/wiki/_compare/302c0b7e200761c9dd9b57e57db540ee0b4293a5
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/wiki/_compare/302c0b7e200761c9dd9b57e57db540ee0b4293a5</example>
        [global::Newtonsoft.Json.JsonProperty("commit_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationWikiCommit" /> class.
        /// </summary>
        /// <param name="path">
        /// The file path of the wiki page<br/>
        /// Example: /example/Home.md
        /// </param>
        /// <param name="startLine">
        /// Line number at which the secret starts in the file
        /// </param>
        /// <param name="endLine">
        /// Line number at which the secret ends in the file
        /// </param>
        /// <param name="startColumn">
        /// The column at which the secret starts within the start line when the file is interpreted as 8-bit ASCII.
        /// </param>
        /// <param name="endColumn">
        /// The column at which the secret ends within the end line when the file is interpreted as 8-bit ASCII.
        /// </param>
        /// <param name="blobSha">
        /// SHA-1 hash ID of the associated blob<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </param>
        /// <param name="pageUrl">
        /// The GitHub URL to get the associated wiki page<br/>
        /// Example: https://github.com/octocat/Hello-World/wiki/Home/302c0b7e200761c9dd9b57e57db540ee0b4293a5
        /// </param>
        /// <param name="commitSha">
        /// SHA-1 hash ID of the associated commit<br/>
        /// Example: 302c0b7e200761c9dd9b57e57db540ee0b4293a5
        /// </param>
        /// <param name="commitUrl">
        /// The GitHub URL to get the associated wiki commit<br/>
        /// Example: https://github.com/octocat/Hello-World/wiki/_compare/302c0b7e200761c9dd9b57e57db540ee0b4293a5
        /// </param>
        public SecretScanningLocationWikiCommit(
            string path,
            double startLine,
            double endLine,
            double startColumn,
            double endColumn,
            string blobSha,
            string pageUrl,
            string commitSha,
            string commitUrl)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.StartLine = startLine;
            this.EndLine = endLine;
            this.StartColumn = startColumn;
            this.EndColumn = endColumn;
            this.BlobSha = blobSha ?? throw new global::System.ArgumentNullException(nameof(blobSha));
            this.PageUrl = pageUrl ?? throw new global::System.ArgumentNullException(nameof(pageUrl));
            this.CommitSha = commitSha ?? throw new global::System.ArgumentNullException(nameof(commitSha));
            this.CommitUrl = commitUrl ?? throw new global::System.ArgumentNullException(nameof(commitUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationWikiCommit" /> class.
        /// </summary>
        public SecretScanningLocationWikiCommit()
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
        public static global::G.SecretScanningLocationWikiCommit? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SecretScanningLocationWikiCommit>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.SecretScanningLocationWikiCommit?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.SecretScanningLocationWikiCommit?>(serializer.Deserialize<global::G.SecretScanningLocationWikiCommit>(jsonReader));
        }

    }
}
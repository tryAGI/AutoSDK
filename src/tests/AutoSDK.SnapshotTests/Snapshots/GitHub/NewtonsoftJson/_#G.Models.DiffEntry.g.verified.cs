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
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// Example: file1.txt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Example: added
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DiffEntryStatus Status { get; set; } = default!;

        /// <summary>
        /// Example: 103
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additions", Required = global::Newtonsoft.Json.Required.Always)]
        public int Additions { get; set; } = default!;

        /// <summary>
        /// Example: 21
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletions", Required = global::Newtonsoft.Json.Required.Always)]
        public int Deletions { get; set; } = default!;

        /// <summary>
        /// Example: 124
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Changes { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/blob/6dcb09b5b57875f334f61aebed695e2e4193db5e/file1.txt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blob_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/raw/6dcb09b5b57875f334f61aebed695e2e4193db5e/file1.txt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RawUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/contents/file1.txt?ref=6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentsUrl { get; set; } = default!;

        /// <summary>
        /// Example: @@ -132,7 +132,7 @@ module Test @@ -1000,7 +1000,7 @@ module Test
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch")]
        public string? Patch { get; set; }

        /// <summary>
        /// Example: file.txt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_filename")]
        public string? PreviousFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiffEntry" /> class.
        /// </summary>
        /// <param name="sha">
        /// Example: bbcd538c8e72b8c175046e27cc8f907076331401
        /// </param>
        /// <param name="filename">
        /// Example: file1.txt
        /// </param>
        /// <param name="status">
        /// Example: added
        /// </param>
        /// <param name="additions">
        /// Example: 103
        /// </param>
        /// <param name="deletions">
        /// Example: 21
        /// </param>
        /// <param name="changes">
        /// Example: 124
        /// </param>
        /// <param name="blobUrl">
        /// Example: https://github.com/octocat/Hello-World/blob/6dcb09b5b57875f334f61aebed695e2e4193db5e/file1.txt
        /// </param>
        /// <param name="rawUrl">
        /// Example: https://github.com/octocat/Hello-World/raw/6dcb09b5b57875f334f61aebed695e2e4193db5e/file1.txt
        /// </param>
        /// <param name="contentsUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/contents/file1.txt?ref=6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="patch">
        /// Example: @@ -132,7 +132,7 @@ module Test @@ -1000,7 +1000,7 @@ module Test
        /// </param>
        /// <param name="previousFilename">
        /// Example: file.txt
        /// </param>
        public DiffEntry(
            string sha,
            string filename,
            global::G.DiffEntryStatus status,
            int additions,
            int deletions,
            int changes,
            string blobUrl,
            string rawUrl,
            string contentsUrl,
            string? patch,
            string? previousFilename)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Status = status;
            this.Additions = additions;
            this.Deletions = deletions;
            this.Changes = changes;
            this.BlobUrl = blobUrl ?? throw new global::System.ArgumentNullException(nameof(blobUrl));
            this.RawUrl = rawUrl ?? throw new global::System.ArgumentNullException(nameof(rawUrl));
            this.ContentsUrl = contentsUrl ?? throw new global::System.ArgumentNullException(nameof(contentsUrl));
            this.Patch = patch;
            this.PreviousFilename = previousFilename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiffEntry" /> class.
        /// </summary>
        public DiffEntry()
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
        public static global::G.DiffEntry? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DiffEntry>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.DiffEntry?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DiffEntry?>(serializer.Deserialize<global::G.DiffEntry>(jsonReader));
        }

    }
}
//HintName: G.Models.CommitComparison.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commit Comparison
    /// </summary>
    public sealed partial class CommitComparison
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/master...topic
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/compare/master...topic</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/compare/master...topic</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/octocat:bbcd538c8e72b8c175046e27cc8f907076331401...octocat:0328041d1152db8ae77652d1618a02e57f745f17
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/compare/octocat:bbcd538c8e72b8c175046e27cc8f907076331401...octocat:0328041d1152db8ae77652d1618a02e57f745f17</example>
        [global::Newtonsoft.Json.JsonProperty("permalink_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PermalinkUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.diff
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/compare/master...topic.diff</example>
        [global::Newtonsoft.Json.JsonProperty("diff_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.patch
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/compare/master...topic.patch</example>
        [global::Newtonsoft.Json.JsonProperty("patch_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PatchUrl { get; set; } = default!;

        /// <summary>
        /// Commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Commit BaseCommit { get; set; } = default!;

        /// <summary>
        /// Commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_base_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Commit MergeBaseCommit { get; set; } = default!;

        /// <summary>
        /// Example: ahead
        /// </summary>
        /// <example>ahead</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CommitComparisonStatus Status { get; set; } = default!;

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::Newtonsoft.Json.JsonProperty("ahead_by", Required = global::Newtonsoft.Json.Required.Always)]
        public int AheadBy { get; set; } = default!;

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("behind_by", Required = global::Newtonsoft.Json.Required.Always)]
        public int BehindBy { get; set; } = default!;

        /// <summary>
        /// Example: 6
        /// </summary>
        /// <example>6</example>
        [global::Newtonsoft.Json.JsonProperty("total_commits", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCommits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Commit> Commits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.IList<global::G.DiffEntry>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitComparison" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/master...topic
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic
        /// </param>
        /// <param name="permalinkUrl">
        /// Example: https://github.com/octocat/Hello-World/compare/octocat:bbcd538c8e72b8c175046e27cc8f907076331401...octocat:0328041d1152db8ae77652d1618a02e57f745f17
        /// </param>
        /// <param name="diffUrl">
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.diff
        /// </param>
        /// <param name="patchUrl">
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.patch
        /// </param>
        /// <param name="baseCommit">
        /// Commit
        /// </param>
        /// <param name="mergeBaseCommit">
        /// Commit
        /// </param>
        /// <param name="status">
        /// Example: ahead
        /// </param>
        /// <param name="aheadBy">
        /// Example: 4
        /// </param>
        /// <param name="behindBy">
        /// Example: 5
        /// </param>
        /// <param name="totalCommits">
        /// Example: 6
        /// </param>
        /// <param name="commits"></param>
        /// <param name="files"></param>
        public CommitComparison(
            string url,
            string htmlUrl,
            string permalinkUrl,
            string diffUrl,
            string patchUrl,
            global::G.Commit baseCommit,
            global::G.Commit mergeBaseCommit,
            global::G.CommitComparisonStatus status,
            int aheadBy,
            int behindBy,
            int totalCommits,
            global::System.Collections.Generic.IList<global::G.Commit> commits,
            global::System.Collections.Generic.IList<global::G.DiffEntry>? files)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.PermalinkUrl = permalinkUrl ?? throw new global::System.ArgumentNullException(nameof(permalinkUrl));
            this.DiffUrl = diffUrl ?? throw new global::System.ArgumentNullException(nameof(diffUrl));
            this.PatchUrl = patchUrl ?? throw new global::System.ArgumentNullException(nameof(patchUrl));
            this.BaseCommit = baseCommit ?? throw new global::System.ArgumentNullException(nameof(baseCommit));
            this.MergeBaseCommit = mergeBaseCommit ?? throw new global::System.ArgumentNullException(nameof(mergeBaseCommit));
            this.Status = status;
            this.AheadBy = aheadBy;
            this.BehindBy = behindBy;
            this.TotalCommits = totalCommits;
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitComparison" /> class.
        /// </summary>
        public CommitComparison()
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
        public static global::G.CommitComparison? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CommitComparison>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CommitComparison?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CommitComparison?>(serializer.Deserialize<global::G.CommitComparison>(jsonReader));
        }

    }
}
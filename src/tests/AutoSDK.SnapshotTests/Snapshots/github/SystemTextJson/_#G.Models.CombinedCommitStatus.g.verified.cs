//HintName: G.Models.CombinedCommitStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Combined Commit Status
    /// </summary>
    public sealed partial class CombinedCommitStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SimpleCommitStatus> Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MinimalRepository Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedCommitStatus" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="statuses"></param>
        /// <param name="sha"></param>
        /// <param name="totalCount"></param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="commitUrl"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CombinedCommitStatus(
            string state,
            global::System.Collections.Generic.IList<global::G.SimpleCommitStatus> statuses,
            string sha,
            int totalCount,
            global::G.MinimalRepository repository,
            string commitUrl,
            string url)
        {
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Statuses = statuses ?? throw new global::System.ArgumentNullException(nameof(statuses));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.TotalCount = totalCount;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.CommitUrl = commitUrl ?? throw new global::System.ArgumentNullException(nameof(commitUrl));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedCommitStatus" /> class.
        /// </summary>
        public CombinedCommitStatus()
        {
        }
    }
}
//HintName: G.Models.CodeSearchResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code Search Result Item
    /// </summary>
    public sealed partial class CodeSearchResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MinimalRepository Repository { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size")]
        public int? FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_modified_at")]
        public global::System.DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Example: [73..77, 77..78]
        /// </summary>
        /// <example>[73..77, 77..78]</example>
        [global::Newtonsoft.Json.JsonProperty("line_numbers")]
        public global::System.Collections.Generic.IList<string>? LineNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_matches")]
        public global::System.Collections.Generic.IList<global::G.SearchResultTextMatche>? TextMatches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSearchResultItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="sha"></param>
        /// <param name="url"></param>
        /// <param name="gitUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="score"></param>
        /// <param name="fileSize"></param>
        /// <param name="language"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="lineNumbers">
        /// Example: [73..77, 77..78]
        /// </param>
        /// <param name="textMatches"></param>
        public CodeSearchResultItem(
            string name,
            string path,
            string sha,
            string url,
            string gitUrl,
            string htmlUrl,
            global::G.MinimalRepository repository,
            double score,
            int? fileSize,
            string? language,
            global::System.DateTime? lastModifiedAt,
            global::System.Collections.Generic.IList<string>? lineNumbers,
            global::System.Collections.Generic.IList<global::G.SearchResultTextMatche>? textMatches)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.GitUrl = gitUrl ?? throw new global::System.ArgumentNullException(nameof(gitUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Score = score;
            this.FileSize = fileSize;
            this.Language = language;
            this.LastModifiedAt = lastModifiedAt;
            this.LineNumbers = lineNumbers;
            this.TextMatches = textMatches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSearchResultItem" /> class.
        /// </summary>
        public CodeSearchResultItem()
        {
        }
    }
}
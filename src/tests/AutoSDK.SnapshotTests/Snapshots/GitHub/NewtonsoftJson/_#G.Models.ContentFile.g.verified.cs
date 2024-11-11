//HintName: G.Models.ContentFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Content File
    /// </summary>
    public sealed partial class ContentFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ContentFileType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding", Required = global::Newtonsoft.Json.Required.Always)]
        public string Encoding { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

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
        public string? GitUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DownloadUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ContentFileLinks Links { get; set; } = default!;

        /// <summary>
        /// Example: "actual/actual.md"
        /// </summary>
        /// <example>"actual/actual.md"</example>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public string? Target { get; set; }

        /// <summary>
        /// Example: "git://example.com/defunkt/dotjs.git"
        /// </summary>
        /// <example>"git://example.com/defunkt/dotjs.git"</example>
        [global::Newtonsoft.Json.JsonProperty("submodule_git_url")]
        public string? SubmoduleGitUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFile" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="encoding"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="content"></param>
        /// <param name="sha"></param>
        /// <param name="url"></param>
        /// <param name="gitUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="links"></param>
        /// <param name="target">
        /// Example: "actual/actual.md"
        /// </param>
        /// <param name="submoduleGitUrl">
        /// Example: "git://example.com/defunkt/dotjs.git"
        /// </param>
        public ContentFile(
            string encoding,
            int size,
            string name,
            string path,
            string content,
            string sha,
            string url,
            string? gitUrl,
            string? htmlUrl,
            string? downloadUrl,
            global::G.ContentFileLinks links,
            global::G.ContentFileType type,
            string? target,
            string? submoduleGitUrl)
        {
            this.Encoding = encoding ?? throw new global::System.ArgumentNullException(nameof(encoding));
            this.Size = size;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.GitUrl = gitUrl ?? throw new global::System.ArgumentNullException(nameof(gitUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.DownloadUrl = downloadUrl ?? throw new global::System.ArgumentNullException(nameof(downloadUrl));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Type = type;
            this.Target = target;
            this.SubmoduleGitUrl = submoduleGitUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFile" /> class.
        /// </summary>
        public ContentFile()
        {
        }
    }
}
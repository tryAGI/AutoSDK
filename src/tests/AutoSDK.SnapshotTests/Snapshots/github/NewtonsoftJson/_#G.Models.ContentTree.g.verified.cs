//HintName: G.Models.ContentTree.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Content Tree
    /// </summary>
    public sealed partial class ContentTree
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_url")]
        public string? GitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entries")]
        public global::System.Collections.Generic.IList<global::G.ContentTreeEntrie>? Entries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ContentTreeLinks Links { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTree" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="sha"></param>
        /// <param name="url"></param>
        /// <param name="links"></param>
        /// <param name="content"></param>
        /// <param name="gitUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="entries"></param>
        public ContentTree(
            string type,
            int size,
            string name,
            string path,
            string sha,
            string url,
            global::G.ContentTreeLinks links,
            string? content,
            string? gitUrl,
            string? htmlUrl,
            string? downloadUrl,
            global::System.Collections.Generic.IList<global::G.ContentTreeEntrie>? entries)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Size = size;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Content = content;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.GitUrl = gitUrl;
            this.HtmlUrl = htmlUrl;
            this.DownloadUrl = downloadUrl;
            this.Entries = entries;
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTree" /> class.
        /// </summary>
        public ContentTree()
        {
        }
    }
}
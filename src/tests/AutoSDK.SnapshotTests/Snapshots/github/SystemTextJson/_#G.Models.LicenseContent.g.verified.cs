//HintName: G.Models.LicenseContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// License Content
    /// </summary>
    public sealed partial class LicenseContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_url")]
        public string? GitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LicenseContentLinks Links { get; set; }

        /// <summary>
        /// License Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public global::G.NullableLicenseSimple? License { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseContent" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="sha"></param>
        /// <param name="size"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="gitUrl"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="encoding"></param>
        /// <param name="links"></param>
        /// <param name="license">
        /// License Simple
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseContent(
            string name,
            string path,
            string sha,
            int size,
            string url,
            string type,
            string content,
            string encoding,
            global::G.LicenseContentLinks links,
            string? htmlUrl,
            string? gitUrl,
            string? downloadUrl,
            global::G.NullableLicenseSimple? license)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Size = size;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Encoding = encoding ?? throw new global::System.ArgumentNullException(nameof(encoding));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.HtmlUrl = htmlUrl;
            this.GitUrl = gitUrl;
            this.DownloadUrl = downloadUrl;
            this.License = license;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseContent" /> class.
        /// </summary>
        public LicenseContent()
        {
        }
    }
}
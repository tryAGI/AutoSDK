﻿//HintName: G.Models.ContentSubmodule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object describing a submodule
    /// </summary>
    public sealed partial class ContentSubmodule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContentSubmoduleTypeJsonConverter))]
        public global::G.ContentSubmoduleType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submodule_git_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubmoduleGitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? GitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ContentSubmoduleLinks Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSubmodule" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="submoduleGitUrl"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="sha"></param>
        /// <param name="url"></param>
        /// <param name="gitUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="links"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentSubmodule(
            string submoduleGitUrl,
            int size,
            string name,
            string path,
            string sha,
            string url,
            string? gitUrl,
            string? htmlUrl,
            string? downloadUrl,
            global::G.ContentSubmoduleLinks links,
            global::G.ContentSubmoduleType type)
        {
            this.SubmoduleGitUrl = submoduleGitUrl ?? throw new global::System.ArgumentNullException(nameof(submoduleGitUrl));
            this.Size = size;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.GitUrl = gitUrl ?? throw new global::System.ArgumentNullException(nameof(gitUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.DownloadUrl = downloadUrl ?? throw new global::System.ArgumentNullException(nameof(downloadUrl));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSubmodule" /> class.
        /// </summary>
        public ContentSubmodule()
        {
        }
    }
}
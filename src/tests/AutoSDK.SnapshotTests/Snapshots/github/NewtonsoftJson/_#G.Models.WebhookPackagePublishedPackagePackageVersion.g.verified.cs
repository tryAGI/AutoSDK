//HintName: G.Models.WebhookPackagePublishedPackagePackageVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackagePackageVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::G.WebhookPackagePublishedPackagePackageVersionAuthor? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public global::G.OneOf<string, object>? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container_metadata")]
        public global::G.WebhookPackagePublishedPackagePackageVersionContainerMetadata? ContainerMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docker_metadata")]
        public global::System.Collections.Generic.IList<global::G.WebhookPackagePublishedPackagePackageVersionDockerMetadataItem>? DockerMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation_command", Required = global::Newtonsoft.Json.Required.Always)]
        public string InstallationCommand { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest")]
        public string? Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("npm_metadata")]
        public global::G.WebhookPackagePublishedPackagePackageVersionNpmMetadata? NpmMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nuget_metadata")]
        public global::System.Collections.Generic.IList<global::G.WebhookPackagePublishedPackagePackageVersionNugetMetadataItem>? NugetMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPackagePublishedPackagePackageVersionPackageFile> PackageFiles { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_url")]
        public string? PackageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prerelease")]
        public bool? Prerelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release")]
        public global::G.WebhookPackagePublishedPackagePackageVersionRelease? Release { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rubygems_metadata")]
        public global::System.Collections.Generic.IList<global::G.WebhookRubygemsMetadata>? RubygemsMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_name")]
        public string? TagName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_commitish")]
        public string? TargetCommitish { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_oid")]
        public string? TargetOid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersion" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="installationCommand"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="packageFiles"></param>
        /// <param name="summary"></param>
        /// <param name="version"></param>
        /// <param name="author"></param>
        /// <param name="body"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="containerMetadata"></param>
        /// <param name="createdAt"></param>
        /// <param name="dockerMetadata"></param>
        /// <param name="draft"></param>
        /// <param name="manifest"></param>
        /// <param name="npmMetadata"></param>
        /// <param name="nugetMetadata"></param>
        /// <param name="packageUrl"></param>
        /// <param name="prerelease"></param>
        /// <param name="release"></param>
        /// <param name="rubygemsMetadata"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="tagName"></param>
        /// <param name="targetCommitish"></param>
        /// <param name="targetOid"></param>
        /// <param name="updatedAt"></param>
        public WebhookPackagePublishedPackagePackageVersion(
            string description,
            string htmlUrl,
            int id,
            string installationCommand,
            global::System.Collections.Generic.IList<object> metadata,
            string name,
            global::System.Collections.Generic.IList<global::G.WebhookPackagePublishedPackagePackageVersionPackageFile> packageFiles,
            string summary,
            string version,
            global::G.WebhookPackagePublishedPackagePackageVersionAuthor? author,
            global::G.OneOf<string, object>? body,
            string? bodyHtml,
            global::G.WebhookPackagePublishedPackagePackageVersionContainerMetadata? containerMetadata,
            string? createdAt,
            global::System.Collections.Generic.IList<global::G.WebhookPackagePublishedPackagePackageVersionDockerMetadataItem>? dockerMetadata,
            bool? draft,
            string? manifest,
            global::G.WebhookPackagePublishedPackagePackageVersionNpmMetadata? npmMetadata,
            global::System.Collections.Generic.IList<global::G.WebhookPackagePublishedPackagePackageVersionNugetMetadataItem>? nugetMetadata,
            string? packageUrl,
            bool? prerelease,
            global::G.WebhookPackagePublishedPackagePackageVersionRelease? release,
            global::System.Collections.Generic.IList<global::G.WebhookRubygemsMetadata>? rubygemsMetadata,
            string? sourceUrl,
            string? tagName,
            string? targetCommitish,
            string? targetOid,
            string? updatedAt)
        {
            this.Author = author;
            this.Body = body;
            this.BodyHtml = bodyHtml;
            this.ContainerMetadata = containerMetadata;
            this.CreatedAt = createdAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.DockerMetadata = dockerMetadata;
            this.Draft = draft;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.InstallationCommand = installationCommand ?? throw new global::System.ArgumentNullException(nameof(installationCommand));
            this.Manifest = manifest;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NpmMetadata = npmMetadata;
            this.NugetMetadata = nugetMetadata;
            this.PackageFiles = packageFiles ?? throw new global::System.ArgumentNullException(nameof(packageFiles));
            this.PackageUrl = packageUrl;
            this.Prerelease = prerelease;
            this.Release = release;
            this.RubygemsMetadata = rubygemsMetadata;
            this.SourceUrl = sourceUrl;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.TagName = tagName;
            this.TargetCommitish = targetCommitish;
            this.TargetOid = targetOid;
            this.UpdatedAt = updatedAt;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersion" /> class.
        /// </summary>
        public WebhookPackagePublishedPackagePackageVersion()
        {
        }
    }
}
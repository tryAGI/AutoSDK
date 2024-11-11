//HintName: G.Models.WebhookPackageUpdatedPackagePackageVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackageUpdatedPackagePackageVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPackageUpdatedPackagePackageVersionAuthor? Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html", Required = global::Newtonsoft.Json.Required.Always)]
        public string BodyHtml { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docker_metadata")]
        public global::System.Collections.Generic.IList<global::G.WebhookPackageUpdatedPackagePackageVersionDockerMetadataItem>? DockerMetadata { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("package_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPackageUpdatedPackagePackageVersionPackageFile> PackageFiles { get; set; } = default!;

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
        public global::G.WebhookPackageUpdatedPackagePackageVersionRelease? Release { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("target_commitish", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetCommitish { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_oid", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetOid { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="WebhookPackageUpdatedPackagePackageVersion" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="body"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="dockerMetadata"></param>
        /// <param name="draft"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="installationCommand"></param>
        /// <param name="manifest"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="packageFiles"></param>
        /// <param name="packageUrl"></param>
        /// <param name="prerelease"></param>
        /// <param name="release"></param>
        /// <param name="rubygemsMetadata"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="summary"></param>
        /// <param name="tagName"></param>
        /// <param name="targetCommitish"></param>
        /// <param name="targetOid"></param>
        /// <param name="updatedAt"></param>
        /// <param name="version"></param>
        public WebhookPackageUpdatedPackagePackageVersion(
            global::G.WebhookPackageUpdatedPackagePackageVersionAuthor? author,
            string body,
            string bodyHtml,
            string createdAt,
            string description,
            string htmlUrl,
            int id,
            string installationCommand,
            global::System.Collections.Generic.IList<object> metadata,
            string name,
            global::System.Collections.Generic.IList<global::G.WebhookPackageUpdatedPackagePackageVersionPackageFile> packageFiles,
            string summary,
            string targetCommitish,
            string targetOid,
            string updatedAt,
            string version,
            global::System.Collections.Generic.IList<global::G.WebhookPackageUpdatedPackagePackageVersionDockerMetadataItem>? dockerMetadata,
            bool? draft,
            string? manifest,
            string? packageUrl,
            bool? prerelease,
            global::G.WebhookPackageUpdatedPackagePackageVersionRelease? release,
            global::System.Collections.Generic.IList<global::G.WebhookRubygemsMetadata>? rubygemsMetadata,
            string? sourceUrl,
            string? tagName)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.BodyHtml = bodyHtml ?? throw new global::System.ArgumentNullException(nameof(bodyHtml));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.InstallationCommand = installationCommand ?? throw new global::System.ArgumentNullException(nameof(installationCommand));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PackageFiles = packageFiles ?? throw new global::System.ArgumentNullException(nameof(packageFiles));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.TargetCommitish = targetCommitish ?? throw new global::System.ArgumentNullException(nameof(targetCommitish));
            this.TargetOid = targetOid ?? throw new global::System.ArgumentNullException(nameof(targetOid));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.DockerMetadata = dockerMetadata;
            this.Draft = draft;
            this.Manifest = manifest;
            this.PackageUrl = packageUrl;
            this.Prerelease = prerelease;
            this.Release = release;
            this.RubygemsMetadata = rubygemsMetadata;
            this.SourceUrl = sourceUrl;
            this.TagName = tagName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackageUpdatedPackagePackageVersion" /> class.
        /// </summary>
        public WebhookPackageUpdatedPackagePackageVersion()
        {
        }
    }
}
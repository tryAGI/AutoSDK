//HintName: G.Models.WebhookPackagePublishedPackagePackageVersion.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::G.WebhookPackagePublishedPackagePackageVersionAuthor? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::G.OneOf<string, object>? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_metadata")]
        public global::G.WebhookPackagePublishedPackagePackageVersionContainerMetadata? ContainerMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker_metadata")]
        public global::System.Collections.Generic.IList<global::G.WebhookPackagePublishedPackagePackageVersionDockerMetadataItem>? DockerMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstallationCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        public string? Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm_metadata")]
        public global::G.WebhookPackagePublishedPackagePackageVersionNpmMetadata? NpmMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nuget_metadata")]
        public global::System.Collections.Generic.IList<global::G.WebhookPackagePublishedPackagePackageVersionNugetMetadataItem>? NugetMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookPackagePublishedPackagePackageVersionPackageFile> PackageFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_url")]
        public string? PackageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prerelease")]
        public bool? Prerelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        public global::G.WebhookPackagePublishedPackagePackageVersionRelease? Release { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubygems_metadata")]
        public global::System.Collections.Generic.IList<global::G.WebhookRubygemsMetadata>? RubygemsMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        public string? TagName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_commitish")]
        public string? TargetCommitish { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_oid")]
        public string? TargetOid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersion" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="body"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="containerMetadata"></param>
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
        /// <param name="npmMetadata"></param>
        /// <param name="nugetMetadata"></param>
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.InstallationCommand = installationCommand ?? throw new global::System.ArgumentNullException(nameof(installationCommand));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PackageFiles = packageFiles ?? throw new global::System.ArgumentNullException(nameof(packageFiles));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Author = author;
            this.Body = body;
            this.BodyHtml = bodyHtml;
            this.ContainerMetadata = containerMetadata;
            this.CreatedAt = createdAt;
            this.DockerMetadata = dockerMetadata;
            this.Draft = draft;
            this.Manifest = manifest;
            this.NpmMetadata = npmMetadata;
            this.NugetMetadata = nugetMetadata;
            this.PackageUrl = packageUrl;
            this.Prerelease = prerelease;
            this.Release = release;
            this.RubygemsMetadata = rubygemsMetadata;
            this.SourceUrl = sourceUrl;
            this.TagName = tagName;
            this.TargetCommitish = targetCommitish;
            this.TargetOid = targetOid;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersion" /> class.
        /// </summary>
        public WebhookPackagePublishedPackagePackageVersion()
        {
        }
    }
}
//HintName: G.Models.WebhookRegistryPackagePublishedRegistryPackagePackageVersion.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRegistryPackagePublishedRegistryPackagePackageVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionAuthor? Author { get; set; }

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
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata? ContainerMetadata { get; set; }

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
        public global::System.Collections.Generic.IList<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionDockerMetadataItem>? DockerMetadata { get; set; }

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
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadata? NpmMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nuget_metadata")]
        public global::System.Collections.Generic.IList<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItem>? NugetMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionPackageFile> PackageFiles { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PackageUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prerelease")]
        public bool? Prerelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionRelease? Release { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rubygems_metadata")]
        public global::System.Collections.Generic.IList<global::G.WebhookRubygemsMetadata>? RubygemsMetadata { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersion" /> class.
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
        /// <param name="summary"></param>
        /// <param name="tagName"></param>
        /// <param name="targetCommitish"></param>
        /// <param name="targetOid"></param>
        /// <param name="updatedAt"></param>
        /// <param name="version"></param>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersion(
            string description,
            string htmlUrl,
            int id,
            string installationCommand,
            global::System.Collections.Generic.IList<object> metadata,
            string name,
            global::System.Collections.Generic.IList<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionPackageFile> packageFiles,
            string packageUrl,
            string summary,
            string version,
            global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionAuthor? author,
            global::G.OneOf<string, object>? body,
            string? bodyHtml,
            global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata? containerMetadata,
            string? createdAt,
            global::System.Collections.Generic.IList<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionDockerMetadataItem>? dockerMetadata,
            bool? draft,
            string? manifest,
            global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadata? npmMetadata,
            global::System.Collections.Generic.IList<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItem>? nugetMetadata,
            bool? prerelease,
            global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionRelease? release,
            global::System.Collections.Generic.IList<global::G.WebhookRubygemsMetadata>? rubygemsMetadata,
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
            this.PackageUrl = packageUrl ?? throw new global::System.ArgumentNullException(nameof(packageUrl));
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
            this.Prerelease = prerelease;
            this.Release = release;
            this.RubygemsMetadata = rubygemsMetadata;
            this.TagName = tagName;
            this.TargetCommitish = targetCommitish;
            this.TargetOid = targetOid;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersion" /> class.
        /// </summary>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersion()
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
        public static global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersion? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersion>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersion?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersion?>(serializer.Deserialize<global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersion>(jsonReader));
        }

    }
}
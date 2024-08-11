//HintName: G.Models.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadata.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("npm_user")]
        public string? NpmUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::System.OneOf<string?, global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataAuthor?>? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bugs")]
        public global::System.OneOf<string?, global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataBugs?>? Bugs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependencies")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataDependencies? Dependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dev_dependencies")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataDevDependencies? DevDependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_dependencies")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataPeerDependencies? PeerDependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optional_dependencies")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataOptionalDependencies? OptionalDependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dist")]
        public global::System.OneOf<string?, global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataDist?>? Dist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_head")]
        public string? GitHead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license")]
        public string? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("main")]
        public string? Main { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::System.OneOf<string?, global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataRepository?>? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scripts")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataScripts? Scripts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_version")]
        public string? NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("npm_version")]
        public string? NpmVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_shrinkwrap")]
        public bool HasShrinkwrap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintainers")]
        public global::System.Collections.Generic.IList<string>? Maintainers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributors")]
        public global::System.Collections.Generic.IList<string>? Contributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engines")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataEngines? Engines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.IList<string>? Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bin")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataBin? Bin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("man")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataMan? Man { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directories")]
        public global::System.OneOf<string?, global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadataDirectories?>? Directories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("os")]
        public global::System.Collections.Generic.IList<string>? Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpu")]
        public global::System.Collections.Generic.IList<string>? Cpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation_command")]
        public string? InstallationCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_oid")]
        public string? CommitOid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_via_actions")]
        public bool PublishedViaActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_by_id")]
        public int DeletedById { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
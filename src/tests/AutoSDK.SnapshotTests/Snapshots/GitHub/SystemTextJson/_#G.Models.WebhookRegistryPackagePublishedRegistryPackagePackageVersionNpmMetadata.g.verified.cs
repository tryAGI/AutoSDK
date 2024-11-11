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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm_user")]
        public string? NpmUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<string, object>? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bugs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<string, object>? Bugs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public object? Dependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dev_dependencies")]
        public object? DevDependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_dependencies")]
        public object? PeerDependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optional_dependencies")]
        public object? OptionalDependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dist")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<string, object>? Dist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_head")]
        public string? GitHead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main")]
        public string? Main { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<string, object>? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scripts")]
        public object? Scripts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_version")]
        public string? NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm_version")]
        public string? NpmVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_shrinkwrap")]
        public bool? HasShrinkwrap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintainers")]
        public global::System.Collections.Generic.IList<string>? Maintainers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        public global::System.Collections.Generic.IList<string>? Contributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engines")]
        public object? Engines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<string>? Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bin")]
        public object? Bin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("man")]
        public object? Man { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<string, object>? Directories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        public global::System.Collections.Generic.IList<string>? Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public global::System.Collections.Generic.IList<string>? Cpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_command")]
        public string? InstallationCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_id")]
        public int? ReleaseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_oid")]
        public string? CommitOid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_via_actions")]
        public bool? PublishedViaActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_by_id")]
        public int? DeletedById { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadata" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="npmUser"></param>
        /// <param name="author"></param>
        /// <param name="bugs"></param>
        /// <param name="dependencies"></param>
        /// <param name="devDependencies"></param>
        /// <param name="peerDependencies"></param>
        /// <param name="optionalDependencies"></param>
        /// <param name="description"></param>
        /// <param name="dist"></param>
        /// <param name="gitHead"></param>
        /// <param name="homepage"></param>
        /// <param name="license"></param>
        /// <param name="main"></param>
        /// <param name="repository"></param>
        /// <param name="scripts"></param>
        /// <param name="id"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="npmVersion"></param>
        /// <param name="hasShrinkwrap"></param>
        /// <param name="maintainers"></param>
        /// <param name="contributors"></param>
        /// <param name="engines"></param>
        /// <param name="keywords"></param>
        /// <param name="files"></param>
        /// <param name="bin"></param>
        /// <param name="man"></param>
        /// <param name="directories"></param>
        /// <param name="os"></param>
        /// <param name="cpu"></param>
        /// <param name="readme"></param>
        /// <param name="installationCommand"></param>
        /// <param name="releaseId"></param>
        /// <param name="commitOid"></param>
        /// <param name="publishedViaActions"></param>
        /// <param name="deletedById"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadata(
            string? name,
            string? version,
            string? npmUser,
            global::G.OneOf<string, object>? author,
            global::G.OneOf<string, object>? bugs,
            object? dependencies,
            object? devDependencies,
            object? peerDependencies,
            object? optionalDependencies,
            string? description,
            global::G.OneOf<string, object>? dist,
            string? gitHead,
            string? homepage,
            string? license,
            string? main,
            global::G.OneOf<string, object>? repository,
            object? scripts,
            string? id,
            string? nodeVersion,
            string? npmVersion,
            bool? hasShrinkwrap,
            global::System.Collections.Generic.IList<string>? maintainers,
            global::System.Collections.Generic.IList<string>? contributors,
            object? engines,
            global::System.Collections.Generic.IList<string>? keywords,
            global::System.Collections.Generic.IList<string>? files,
            object? bin,
            object? man,
            global::G.OneOf<string, object>? directories,
            global::System.Collections.Generic.IList<string>? os,
            global::System.Collections.Generic.IList<string>? cpu,
            string? readme,
            string? installationCommand,
            int? releaseId,
            string? commitOid,
            bool? publishedViaActions,
            int? deletedById)
        {
            this.Name = name;
            this.Version = version;
            this.NpmUser = npmUser;
            this.Author = author;
            this.Bugs = bugs;
            this.Dependencies = dependencies;
            this.DevDependencies = devDependencies;
            this.PeerDependencies = peerDependencies;
            this.OptionalDependencies = optionalDependencies;
            this.Description = description;
            this.Dist = dist;
            this.GitHead = gitHead;
            this.Homepage = homepage;
            this.License = license;
            this.Main = main;
            this.Repository = repository;
            this.Scripts = scripts;
            this.Id = id;
            this.NodeVersion = nodeVersion;
            this.NpmVersion = npmVersion;
            this.HasShrinkwrap = hasShrinkwrap;
            this.Maintainers = maintainers;
            this.Contributors = contributors;
            this.Engines = engines;
            this.Keywords = keywords;
            this.Files = files;
            this.Bin = bin;
            this.Man = man;
            this.Directories = directories;
            this.Os = os;
            this.Cpu = cpu;
            this.Readme = readme;
            this.InstallationCommand = installationCommand;
            this.ReleaseId = releaseId;
            this.CommitOid = commitOid;
            this.PublishedViaActions = publishedViaActions;
            this.DeletedById = deletedById;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadata" /> class.
        /// </summary>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionNpmMetadata()
        {
        }
    }
}
//HintName: G.Models.WebhookPackagePublishedPackagePackageVersionNpmMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackagePackageVersionNpmMetadata
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
        public object? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bugs")]
        public object? Bugs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependencies")]
        public object? Dependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dev_dependencies")]
        public object? DevDependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_dependencies")]
        public object? PeerDependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optional_dependencies")]
        public object? OptionalDependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dist")]
        public object? Dist { get; set; }

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
        public object? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scripts")]
        public object? Scripts { get; set; }

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
        public bool? HasShrinkwrap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintainers")]
        public global::System.Collections.Generic.IList<object>? Maintainers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributors")]
        public global::System.Collections.Generic.IList<object>? Contributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engines")]
        public object? Engines { get; set; }

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
        public object? Bin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("man")]
        public object? Man { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directories")]
        public object? Directories { get; set; }

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
        public int? ReleaseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_oid")]
        public string? CommitOid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_via_actions")]
        public bool? PublishedViaActions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_by_id")]
        public int? DeletedById { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionNpmMetadata" /> class.
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
        public WebhookPackagePublishedPackagePackageVersionNpmMetadata(
            string? name,
            string? version,
            string? npmUser,
            object? author,
            object? bugs,
            object? dependencies,
            object? devDependencies,
            object? peerDependencies,
            object? optionalDependencies,
            string? description,
            object? dist,
            string? gitHead,
            string? homepage,
            string? license,
            string? main,
            object? repository,
            object? scripts,
            string? id,
            string? nodeVersion,
            string? npmVersion,
            bool? hasShrinkwrap,
            global::System.Collections.Generic.IList<object>? maintainers,
            global::System.Collections.Generic.IList<object>? contributors,
            object? engines,
            global::System.Collections.Generic.IList<string>? keywords,
            global::System.Collections.Generic.IList<string>? files,
            object? bin,
            object? man,
            object? directories,
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
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionNpmMetadata" /> class.
        /// </summary>
        public WebhookPackagePublishedPackagePackageVersionNpmMetadata()
        {
        }
    }
}
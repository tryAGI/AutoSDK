//HintName: G.Models.WebhookRubygemsMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRubygemsMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_info")]
        public global::G.WebhookRubygemsMetadataVersionInfo? VersionInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Dependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_oid")]
        public string? CommitOid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRubygemsMetadata" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="homepage"></param>
        /// <param name="versionInfo"></param>
        /// <param name="platform"></param>
        /// <param name="metadata"></param>
        /// <param name="repo"></param>
        /// <param name="dependencies"></param>
        /// <param name="commitOid"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRubygemsMetadata(
            string? name,
            string? description,
            string? readme,
            string? homepage,
            global::G.WebhookRubygemsMetadataVersionInfo? versionInfo,
            string? platform,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? repo,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? dependencies,
            string? commitOid)
        {
            this.Name = name;
            this.Description = description;
            this.Readme = readme;
            this.Homepage = homepage;
            this.VersionInfo = versionInfo;
            this.Platform = platform;
            this.Metadata = metadata;
            this.Repo = repo;
            this.Dependencies = dependencies;
            this.CommitOid = commitOid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRubygemsMetadata" /> class.
        /// </summary>
        public WebhookRubygemsMetadata()
        {
        }
    }
}
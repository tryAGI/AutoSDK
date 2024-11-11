//HintName: G.Models.RateLimitOverviewResources.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitOverviewResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("core")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RateLimit Core { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graphql")]
        public global::G.RateLimit? Graphql { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RateLimit Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_search")]
        public global::G.RateLimit? CodeSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_import")]
        public global::G.RateLimit? SourceImport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_manifest")]
        public global::G.RateLimit? IntegrationManifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_upload")]
        public global::G.RateLimit? CodeScanningUpload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions_runner_registration")]
        public global::G.RateLimit? ActionsRunnerRegistration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim")]
        public global::G.RateLimit? Scim { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_snapshots")]
        public global::G.RateLimit? DependencySnapshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverviewResources" /> class.
        /// </summary>
        /// <param name="core"></param>
        /// <param name="graphql"></param>
        /// <param name="search"></param>
        /// <param name="codeSearch"></param>
        /// <param name="sourceImport"></param>
        /// <param name="integrationManifest"></param>
        /// <param name="codeScanningUpload"></param>
        /// <param name="actionsRunnerRegistration"></param>
        /// <param name="scim"></param>
        /// <param name="dependencySnapshots"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RateLimitOverviewResources(
            global::G.RateLimit core,
            global::G.RateLimit search,
            global::G.RateLimit? graphql,
            global::G.RateLimit? codeSearch,
            global::G.RateLimit? sourceImport,
            global::G.RateLimit? integrationManifest,
            global::G.RateLimit? codeScanningUpload,
            global::G.RateLimit? actionsRunnerRegistration,
            global::G.RateLimit? scim,
            global::G.RateLimit? dependencySnapshots)
        {
            this.Core = core ?? throw new global::System.ArgumentNullException(nameof(core));
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
            this.Graphql = graphql;
            this.CodeSearch = codeSearch;
            this.SourceImport = sourceImport;
            this.IntegrationManifest = integrationManifest;
            this.CodeScanningUpload = codeScanningUpload;
            this.ActionsRunnerRegistration = actionsRunnerRegistration;
            this.Scim = scim;
            this.DependencySnapshots = dependencySnapshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverviewResources" /> class.
        /// </summary>
        public RateLimitOverviewResources()
        {
        }
    }
}
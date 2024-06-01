//HintName: G.Models.Page.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration for GitHub Pages for a repository.
    /// </summary>
    public sealed partial class Page
    {
        /// <summary>
        /// The API address for accessing this Page resource.
        /// <br/>Example: https://api.github.com/repos/github/hello-world/pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The status of the most recent build of the Page.
        /// <br/>Example: built
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.PageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required PageStatus? Status { get; set; }

        /// <summary>
        /// The Pages site's custom domain
        /// <br/>Example: example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Cname { get; set; }

        /// <summary>
        /// The state if the domain is verified
        /// <br/>Example: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected_domain_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.PageProtectedDomainStateJsonConverter))]
        public PageProtectedDomainState? ProtectedDomainState { get; set; }

        /// <summary>
        /// The timestamp when a pending domain becomes unverified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_domain_unverified_at")]
        public global::System.DateTime? PendingDomainUnverifiedAt { get; set; }

        /// <summary>
        /// Whether the Page has a custom 404 page.
        /// <br/>Default Value: false
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_404")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Custom404 { get; set; }

        /// <summary>
        /// The web address the Page can be accessed from.
        /// <br/>Example: https://example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// The process in which the Page will be built.
        /// <br/>Example: legacy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.PageBuildTypeJsonConverter))]
        public PageBuildType? BuildType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public PagesSourceHash? Source { get; set; }

        /// <summary>
        /// Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("https_certificate")]
        public PagesHttpsCertificate? HttpsCertificate { get; set; }

        /// <summary>
        /// Whether https is enabled on the domain
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("https_enforced")]
        public bool HttpsEnforced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
﻿//HintName: G.Models.Page.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration for GitHub Pages for a repository.
    /// </summary>
    public sealed partial class Page
    {
        /// <summary>
        /// The API address for accessing this Page resource.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/pages
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/pages</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The status of the most recent build of the Page.<br/>
        /// Example: built
        /// </summary>
        /// <example>built</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PageStatus? Status { get; set; } = default!;

        /// <summary>
        /// The Pages site's custom domain<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::Newtonsoft.Json.JsonProperty("cname", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Cname { get; set; } = default!;

        /// <summary>
        /// The state if the domain is verified<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::Newtonsoft.Json.JsonProperty("protected_domain_state")]
        public global::G.PageProtectedDomainState? ProtectedDomainState { get; set; }

        /// <summary>
        /// The timestamp when a pending domain becomes unverified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_domain_unverified_at")]
        public global::System.DateTime? PendingDomainUnverifiedAt { get; set; }

        /// <summary>
        /// Whether the Page has a custom 404 page.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <default>false</default>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("custom_404", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Custom404 { get; set; } = default!;

        /// <summary>
        /// The web address the Page can be accessed from.<br/>
        /// Example: https://example.com
        /// </summary>
        /// <example>https://example.com</example>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// The process in which the Page will be built.<br/>
        /// Example: legacy
        /// </summary>
        /// <example>legacy</example>
        [global::Newtonsoft.Json.JsonProperty("build_type")]
        public global::G.PageBuildType? BuildType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.PagesSourceHash? Source { get; set; }

        /// <summary>
        /// Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("https_certificate")]
        public global::G.PagesHttpsCertificate? HttpsCertificate { get; set; }

        /// <summary>
        /// Whether https is enabled on the domain<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("https_enforced")]
        public bool? HttpsEnforced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
        /// </summary>
        /// <param name="url">
        /// The API address for accessing this Page resource.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/pages
        /// </param>
        /// <param name="status">
        /// The status of the most recent build of the Page.<br/>
        /// Example: built
        /// </param>
        /// <param name="cname">
        /// The Pages site's custom domain<br/>
        /// Example: example.com
        /// </param>
        /// <param name="protectedDomainState">
        /// The state if the domain is verified<br/>
        /// Example: pending
        /// </param>
        /// <param name="pendingDomainUnverifiedAt">
        /// The timestamp when a pending domain becomes unverified.
        /// </param>
        /// <param name="custom404">
        /// Whether the Page has a custom 404 page.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="htmlUrl">
        /// The web address the Page can be accessed from.<br/>
        /// Example: https://example.com
        /// </param>
        /// <param name="buildType">
        /// The process in which the Page will be built.<br/>
        /// Example: legacy
        /// </param>
        /// <param name="source"></param>
        /// <param name="public">
        /// Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.<br/>
        /// Example: true
        /// </param>
        /// <param name="httpsCertificate"></param>
        /// <param name="httpsEnforced">
        /// Whether https is enabled on the domain<br/>
        /// Example: true
        /// </param>
        public Page(
            string url,
            global::G.PageStatus? status,
            string? cname,
            bool custom404,
            bool @public,
            global::G.PageProtectedDomainState? protectedDomainState,
            global::System.DateTime? pendingDomainUnverifiedAt,
            string? htmlUrl,
            global::G.PageBuildType? buildType,
            global::G.PagesSourceHash? source,
            global::G.PagesHttpsCertificate? httpsCertificate,
            bool? httpsEnforced)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Status = status;
            this.Cname = cname ?? throw new global::System.ArgumentNullException(nameof(cname));
            this.Custom404 = custom404;
            this.Public = @public;
            this.ProtectedDomainState = protectedDomainState;
            this.PendingDomainUnverifiedAt = pendingDomainUnverifiedAt;
            this.HtmlUrl = htmlUrl;
            this.BuildType = buildType;
            this.Source = source;
            this.HttpsCertificate = httpsCertificate;
            this.HttpsEnforced = httpsEnforced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
        /// </summary>
        public Page()
        {
        }
    }
}
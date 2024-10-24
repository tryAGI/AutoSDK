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
        /// The API address for accessing this Page resource.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The status of the most recent build of the Page.<br/>
        /// Example: built
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PageStatus? Status { get; set; }

        /// <summary>
        /// The Pages site's custom domain<br/>
        /// Example: example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Cname { get; set; }

        /// <summary>
        /// The state if the domain is verified<br/>
        /// Example: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected_domain_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PageProtectedDomainStateJsonConverter))]
        public global::G.PageProtectedDomainState? ProtectedDomainState { get; set; }

        /// <summary>
        /// The timestamp when a pending domain becomes unverified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_domain_unverified_at")]
        public global::System.DateTime? PendingDomainUnverifiedAt { get; set; }

        /// <summary>
        /// Whether the Page has a custom 404 page.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_404")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Custom404 { get; set; } = false;

        /// <summary>
        /// The web address the Page can be accessed from.<br/>
        /// Example: https://example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// The process in which the Page will be built.<br/>
        /// Example: legacy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PageBuildTypeJsonConverter))]
        public global::G.PageBuildType? BuildType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::G.PagesSourceHash? Source { get; set; }

        /// <summary>
        /// Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("https_certificate")]
        public global::G.PagesHttpsCertificate? HttpsCertificate { get; set; }

        /// <summary>
        /// Whether https is enabled on the domain<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("https_enforced")]
        public bool? HttpsEnforced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.Page? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Page),
                jsonSerializerContext) as global::G.Page;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Page? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Page>(
                json,
                jsonSerializerOptions);
        }

    }
}
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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The status of the most recent build of the Page.<br/>
        /// Example: built
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PageStatus? Status { get; set; } = default!;

        /// <summary>
        /// The Pages site's custom domain<br/>
        /// Example: example.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cname", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Cname { get; set; } = default!;

        /// <summary>
        /// The state if the domain is verified<br/>
        /// Example: pending
        /// </summary>
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
        [global::Newtonsoft.Json.JsonProperty("custom_404", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Custom404 { get; set; } = default!;

        /// <summary>
        /// The web address the Page can be accessed from.<br/>
        /// Example: https://example.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// The process in which the Page will be built.<br/>
        /// Example: legacy
        /// </summary>
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
        [global::Newtonsoft.Json.JsonProperty("https_enforced")]
        public bool? HttpsEnforced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.Page? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Page>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Page?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Page?>(serializer.Deserialize<global::G.Page>(jsonReader));
        }

    }
}
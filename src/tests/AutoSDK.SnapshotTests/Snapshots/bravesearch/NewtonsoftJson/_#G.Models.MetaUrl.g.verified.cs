//HintName: G.Models.MetaUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregated URL information for a result.
    /// </summary>
    public sealed partial class MetaUrl
    {
        /// <summary>
        /// The URL scheme (e.g., https).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scheme")]
        public string? Scheme { get; set; }

        /// <summary>
        /// The network location (domain).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("netloc")]
        public string? Netloc { get; set; }

        /// <summary>
        /// The hostname.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// URL to the site favicon.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// The URL path.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaUrl" /> class.
        /// </summary>
        /// <param name="scheme">
        /// The URL scheme (e.g., https).
        /// </param>
        /// <param name="netloc">
        /// The network location (domain).
        /// </param>
        /// <param name="hostname">
        /// The hostname.
        /// </param>
        /// <param name="favicon">
        /// URL to the site favicon.
        /// </param>
        /// <param name="path">
        /// The URL path.
        /// </param>
        public MetaUrl(
            string? scheme,
            string? netloc,
            string? hostname,
            string? favicon,
            string? path)
        {
            this.Scheme = scheme;
            this.Netloc = netloc;
            this.Hostname = hostname;
            this.Favicon = favicon;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaUrl" /> class.
        /// </summary>
        public MetaUrl()
        {
        }
    }
}
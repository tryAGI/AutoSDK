//HintName: G.Models.GetToolkitsChangelogResponseItemVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolkitsChangelogResponseItemVersion
    {
        /// <summary>
        /// Version identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Changelog for this version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changelog", Required = global::Newtonsoft.Json.Required.Always)]
        public string Changelog { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsChangelogResponseItemVersion" /> class.
        /// </summary>
        /// <param name="version">
        /// Version identifier
        /// </param>
        /// <param name="changelog">
        /// Changelog for this version
        /// </param>
        public GetToolkitsChangelogResponseItemVersion(
            string version,
            string changelog)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Changelog = changelog ?? throw new global::System.ArgumentNullException(nameof(changelog));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsChangelogResponseItemVersion" /> class.
        /// </summary>
        public GetToolkitsChangelogResponseItemVersion()
        {
        }
    }
}
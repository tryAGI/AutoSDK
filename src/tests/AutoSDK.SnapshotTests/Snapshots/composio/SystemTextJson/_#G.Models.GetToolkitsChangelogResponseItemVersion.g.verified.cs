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
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Changelog for this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changelog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Changelog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
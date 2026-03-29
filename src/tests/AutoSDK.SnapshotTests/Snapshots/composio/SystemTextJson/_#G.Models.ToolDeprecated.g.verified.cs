//HintName: G.Models.ToolDeprecated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolDeprecated
    {
        /// <summary>
        /// The display name of the tool<br/>
        /// Example: GitHub Actions
        /// </summary>
        /// <example>GitHub Actions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Current version identifier of the tool<br/>
        /// Example: 20250905_00
        /// </summary>
        /// <example>20250905_00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// List of all available versions for this tool<br/>
        /// Example: [20250905_00, 20250906_00]
        /// </summary>
        /// <example>[20250905_00, 20250906_00]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvailableVersions { get; set; }

        /// <summary>
        /// Indicates if this tool is deprecated and may be removed in the future<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deprecated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDeprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolDeprecatedToolkit Toolkit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDeprecated" /> class.
        /// </summary>
        /// <param name="displayName">
        /// The display name of the tool<br/>
        /// Example: GitHub Actions
        /// </param>
        /// <param name="version">
        /// Current version identifier of the tool<br/>
        /// Example: 20250905_00
        /// </param>
        /// <param name="availableVersions">
        /// List of all available versions for this tool<br/>
        /// Example: [20250905_00, 20250906_00]
        /// </param>
        /// <param name="isDeprecated">
        /// Indicates if this tool is deprecated and may be removed in the future<br/>
        /// Example: false
        /// </param>
        /// <param name="toolkit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolDeprecated(
            string displayName,
            string version,
            global::System.Collections.Generic.IList<string> availableVersions,
            bool isDeprecated,
            global::G.ToolDeprecatedToolkit toolkit)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.AvailableVersions = availableVersions ?? throw new global::System.ArgumentNullException(nameof(availableVersions));
            this.IsDeprecated = isDeprecated;
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDeprecated" /> class.
        /// </summary>
        public ToolDeprecated()
        {
        }
    }
}
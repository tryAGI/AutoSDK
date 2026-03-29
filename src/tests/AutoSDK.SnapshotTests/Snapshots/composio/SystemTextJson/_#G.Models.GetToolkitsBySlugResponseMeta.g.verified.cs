//HintName: G.Models.GetToolkitsBySlugResponseMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comprehensive metadata for the toolkit including dates, descriptions, and statistics
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseMeta
    {
        /// <summary>
        /// Creation date and time of the toolkit<br/>
        /// Example: 2023-01-15T09:30:00.000Z
        /// </summary>
        /// <example>2023-01-15T09:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Last modification date and time of the toolkit<br/>
        /// Example: 2023-05-20T14:45:00.000Z
        /// </summary>
        /// <example>2023-05-20T14:45:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Human-readable description explaining the toolkit's purpose and functionality<br/>
        /// Example: Integrate with GitHub repositories, issues, pull requests, and more.
        /// </summary>
        /// <example>Integrate with GitHub repositories, issues, pull requests, and more.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Image URL for the toolkit's branding<br/>
        /// Example: https://assets.composio.dev/logos/github.png
        /// </summary>
        /// <example>https://assets.composio.dev/logos/github.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logo { get; set; }

        /// <summary>
        /// Link to the toolkit's main application or service website<br/>
        /// Example: https://github.com
        /// </summary>
        /// <example>https://github.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_url")]
        public string? AppUrl { get; set; }

        /// <summary>
        /// List of categories associated with this toolkit<br/>
        /// Example: [{"name":"Developer Tools","slug":"developer-tools"}, {"name":"Productivity","slug":"productivity"}]
        /// </summary>
        /// <example>[{"name":"Developer Tools","slug":"developer-tools"}, {"name":"Productivity","slug":"productivity"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseMetaCategorie> Categories { get; set; }

        /// <summary>
        /// Count of available triggers in this toolkit<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TriggersCount { get; set; }

        /// <summary>
        /// Count of available tools in this toolkit<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ToolsCount { get; set; }

        /// <summary>
        /// Version of the toolkit<br/>
        /// Example: 20250905_00
        /// </summary>
        /// <example>20250905_00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Available versions of the toolkit<br/>
        /// Example: [20250905_00, 20250906_00]
        /// </summary>
        /// <example>[20250905_00, 20250906_00]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvailableVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseMeta" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Creation date and time of the toolkit<br/>
        /// Example: 2023-01-15T09:30:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Last modification date and time of the toolkit<br/>
        /// Example: 2023-05-20T14:45:00.000Z
        /// </param>
        /// <param name="description">
        /// Human-readable description explaining the toolkit's purpose and functionality<br/>
        /// Example: Integrate with GitHub repositories, issues, pull requests, and more.
        /// </param>
        /// <param name="logo">
        /// Image URL for the toolkit's branding<br/>
        /// Example: https://assets.composio.dev/logos/github.png
        /// </param>
        /// <param name="categories">
        /// List of categories associated with this toolkit<br/>
        /// Example: [{"name":"Developer Tools","slug":"developer-tools"}, {"name":"Productivity","slug":"productivity"}]
        /// </param>
        /// <param name="triggersCount">
        /// Count of available triggers in this toolkit<br/>
        /// Example: 5
        /// </param>
        /// <param name="toolsCount">
        /// Count of available tools in this toolkit<br/>
        /// Example: 12
        /// </param>
        /// <param name="version">
        /// Version of the toolkit<br/>
        /// Example: 20250905_00
        /// </param>
        /// <param name="availableVersions">
        /// Available versions of the toolkit<br/>
        /// Example: [20250905_00, 20250906_00]
        /// </param>
        /// <param name="appUrl">
        /// Link to the toolkit's main application or service website<br/>
        /// Example: https://github.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolkitsBySlugResponseMeta(
            string createdAt,
            string updatedAt,
            string description,
            string logo,
            global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseMetaCategorie> categories,
            double triggersCount,
            double toolsCount,
            string version,
            global::System.Collections.Generic.IList<string> availableVersions,
            string? appUrl)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Logo = logo ?? throw new global::System.ArgumentNullException(nameof(logo));
            this.AppUrl = appUrl;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.TriggersCount = triggersCount;
            this.ToolsCount = toolsCount;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.AvailableVersions = availableVersions ?? throw new global::System.ArgumentNullException(nameof(availableVersions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseMeta" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseMeta()
        {
        }
    }
}
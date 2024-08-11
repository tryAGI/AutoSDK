//HintName: G.Models.RepositoryAdvisoryUpdateVulnerabilitiePackage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the package affected by the vulnerability.
    /// </summary>
    public sealed partial class RepositoryAdvisoryUpdateVulnerabilitiePackage
    {
        /// <summary>
        /// The package's language or package management ecosystem.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ecosystem")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SecurityAdvisoryEcosystemsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SecurityAdvisoryEcosystems? Ecosystem { get; set; }

        /// <summary>
        /// The unique package name within its ecosystem.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
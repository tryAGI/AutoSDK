﻿//HintName: G.Models.RepositoryAdvisoryCreateVulnerabilitiePackage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the package affected by the vulnerability.
    /// </summary>
    public sealed partial class RepositoryAdvisoryCreateVulnerabilitiePackage
    {
        /// <summary>
        /// The package's language or package management ecosystem.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ecosystem")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SecurityAdvisoryEcosystemsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SecurityAdvisoryEcosystems Ecosystem { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreateVulnerabilitiePackage" /> class.
        /// </summary>
        /// <param name="ecosystem">
        /// The package's language or package management ecosystem.
        /// </param>
        /// <param name="name">
        /// The unique package name within its ecosystem.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryAdvisoryCreateVulnerabilitiePackage(
            global::G.SecurityAdvisoryEcosystems ecosystem,
            string? name)
        {
            this.Ecosystem = ecosystem;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreateVulnerabilitiePackage" /> class.
        /// </summary>
        public RepositoryAdvisoryCreateVulnerabilitiePackage()
        {
        }
    }
}
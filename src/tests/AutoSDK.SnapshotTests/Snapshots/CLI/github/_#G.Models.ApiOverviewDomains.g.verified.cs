//HintName: G.Models.ApiOverviewDomains.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiOverviewDomains
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public global::System.Collections.Generic.IList<string>? Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codespaces")]
        public global::System.Collections.Generic.IList<string>? Codespaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot")]
        public global::System.Collections.Generic.IList<string>? Copilot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::System.Collections.Generic.IList<string>? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<string>? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_attestations")]
        public global::G.ApiOverviewDomainsArtifactAttestations? ArtifactAttestations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewDomains" /> class.
        /// </summary>
        /// <param name="website"></param>
        /// <param name="codespaces"></param>
        /// <param name="copilot"></param>
        /// <param name="packages"></param>
        /// <param name="actions"></param>
        /// <param name="artifactAttestations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiOverviewDomains(
            global::System.Collections.Generic.IList<string>? website,
            global::System.Collections.Generic.IList<string>? codespaces,
            global::System.Collections.Generic.IList<string>? copilot,
            global::System.Collections.Generic.IList<string>? packages,
            global::System.Collections.Generic.IList<string>? actions,
            global::G.ApiOverviewDomainsArtifactAttestations? artifactAttestations)
        {
            this.Website = website;
            this.Codespaces = codespaces;
            this.Copilot = copilot;
            this.Packages = packages;
            this.Actions = actions;
            this.ArtifactAttestations = artifactAttestations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewDomains" /> class.
        /// </summary>
        public ApiOverviewDomains()
        {
        }
    }
}
//HintName: G.Models.DependencyGraphSpdxSbom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A schema for the SPDX JSON format returned by the Dependency Graph.
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sbom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependencyGraphSpdxSbomSbom Sbom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbom" /> class.
        /// </summary>
        /// <param name="sbom"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependencyGraphSpdxSbom(
            global::G.DependencyGraphSpdxSbomSbom sbom)
        {
            this.Sbom = sbom ?? throw new global::System.ArgumentNullException(nameof(sbom));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbom" /> class.
        /// </summary>
        public DependencyGraphSpdxSbom()
        {
        }
    }
}
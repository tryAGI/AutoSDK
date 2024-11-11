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
        [global::Newtonsoft.Json.JsonProperty("sbom", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependencyGraphSpdxSbomSbom Sbom { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbom" /> class.
        /// </summary>
        /// <param name="sbom"></param>
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
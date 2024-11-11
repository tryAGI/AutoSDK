//HintName: G.Models.DependencyGraphSpdxSbomSbomCreationInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbomCreationInfo
    {
        /// <summary>
        /// The date and time the SPDX document was created.<br/>
        /// Example: 2021-11-03T00:00:00Z
        /// </summary>
        /// <example>2021-11-03T00:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public string Created { get; set; } = default!;

        /// <summary>
        /// The tools that were used to generate the SPDX document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creators", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Creators { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomCreationInfo" /> class.
        /// </summary>
        /// <param name="created">
        /// The date and time the SPDX document was created.<br/>
        /// Example: 2021-11-03T00:00:00Z
        /// </param>
        /// <param name="creators">
        /// The tools that were used to generate the SPDX document.
        /// </param>
        public DependencyGraphSpdxSbomSbomCreationInfo(
            string created,
            global::System.Collections.Generic.IList<string> creators)
        {
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.Creators = creators ?? throw new global::System.ArgumentNullException(nameof(creators));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomCreationInfo" /> class.
        /// </summary>
        public DependencyGraphSpdxSbomSbomCreationInfo()
        {
        }
    }
}
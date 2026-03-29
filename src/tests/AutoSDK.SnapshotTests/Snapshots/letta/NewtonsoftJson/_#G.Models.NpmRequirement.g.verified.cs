//HintName: G.Models.NpmRequirement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NpmRequirement
    {
        /// <summary>
        /// Name of the npm package.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional version of the package, following semantic versioning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NpmRequirement" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the npm package.
        /// </param>
        /// <param name="version">
        /// Optional version of the package, following semantic versioning.
        /// </param>
        public NpmRequirement(
            string name,
            string? version)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NpmRequirement" /> class.
        /// </summary>
        public NpmRequirement()
        {
        }
    }
}
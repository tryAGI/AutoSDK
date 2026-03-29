//HintName: G.Models.PipRequirement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipRequirement
    {
        /// <summary>
        /// Name of the pip package.
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
        /// Initializes a new instance of the <see cref="PipRequirement" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the pip package.
        /// </param>
        /// <param name="version">
        /// Optional version of the package, following semantic versioning.
        /// </param>
        public PipRequirement(
            string name,
            string? version)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipRequirement" /> class.
        /// </summary>
        public PipRequirement()
        {
        }
    }
}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional version of the package, following semantic versioning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
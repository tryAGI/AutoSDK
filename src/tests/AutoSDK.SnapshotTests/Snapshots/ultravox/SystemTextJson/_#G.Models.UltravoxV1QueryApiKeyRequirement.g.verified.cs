//HintName: G.Models.UltravoxV1QueryApiKeyRequirement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A security requirement that will cause an API key to be added to the query string.
    /// </summary>
    public sealed partial class UltravoxV1QueryApiKeyRequirement
    {
        /// <summary>
        /// The name of the query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1QueryApiKeyRequirement" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the query parameter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1QueryApiKeyRequirement(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1QueryApiKeyRequirement" /> class.
        /// </summary>
        public UltravoxV1QueryApiKeyRequirement()
        {
        }
    }
}
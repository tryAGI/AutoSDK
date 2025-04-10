//HintName: G.Models.UltravoxV1HeaderApiKeyRequirement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A security requirement that will cause an API key to be added to the header.
    /// </summary>
    public sealed partial class UltravoxV1HeaderApiKeyRequirement
    {
        /// <summary>
        /// The name of the header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1HeaderApiKeyRequirement" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1HeaderApiKeyRequirement(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1HeaderApiKeyRequirement" /> class.
        /// </summary>
        public UltravoxV1HeaderApiKeyRequirement()
        {
        }
    }
}
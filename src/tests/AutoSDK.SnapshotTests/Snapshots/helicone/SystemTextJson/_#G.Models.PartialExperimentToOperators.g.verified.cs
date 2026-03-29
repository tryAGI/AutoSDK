//HintName: G.Models.PartialExperimentToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialExperimentToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::G.PartialTextOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        public global::G.PartialTextOperators? PromptV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialExperimentToOperators" /> class.
        /// </summary>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptV2">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialExperimentToOperators(
            global::G.PartialTextOperators? id,
            global::G.PartialTextOperators? promptV2)
        {
            this.Id = id;
            this.PromptV2 = promptV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialExperimentToOperators" /> class.
        /// </summary>
        public PartialExperimentToOperators()
        {
        }
    }
}
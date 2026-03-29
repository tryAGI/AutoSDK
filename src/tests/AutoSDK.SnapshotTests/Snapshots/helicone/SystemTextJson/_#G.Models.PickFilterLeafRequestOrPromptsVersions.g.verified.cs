//HintName: G.Models.PickFilterLeafRequestOrPromptsVersions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickFilterLeafRequestOrPromptsVersions
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::G.PartialRequestTableToOperators? Request { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts_versions")]
        public global::G.PartialPromptVersionsToOperators? PromptsVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafRequestOrPromptsVersions" /> class.
        /// </summary>
        /// <param name="request">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptsVersions">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickFilterLeafRequestOrPromptsVersions(
            global::G.PartialRequestTableToOperators? request,
            global::G.PartialPromptVersionsToOperators? promptsVersions)
        {
            this.Request = request;
            this.PromptsVersions = promptsVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafRequestOrPromptsVersions" /> class.
        /// </summary>
        public PickFilterLeafRequestOrPromptsVersions()
        {
        }
    }
}
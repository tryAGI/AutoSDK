//HintName: G.Models.PickFilterLeafPromptV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickFilterLeafPromptV2
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_v2")]
        public global::G.PartialPromptToOperators? PromptV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafPromptV2" /> class.
        /// </summary>
        /// <param name="promptV2">
        /// Make all properties in T optional
        /// </param>
        public PickFilterLeafPromptV2(
            global::G.PartialPromptToOperators? promptV2)
        {
            this.PromptV2 = promptV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafPromptV2" /> class.
        /// </summary>
        public PickFilterLeafPromptV2()
        {
        }
    }
}
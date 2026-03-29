//HintName: G.Models.Sam2PromptSet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam2PromptSet
    {
        /// <summary>
        /// An optional list of prompts for masks to predict. Each prompt can include a bounding box and / or a set of postive or negative points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts")]
        public global::System.Collections.Generic.IList<global::G.Sam2Prompt>? Prompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2PromptSet" /> class.
        /// </summary>
        /// <param name="prompts">
        /// An optional list of prompts for masks to predict. Each prompt can include a bounding box and / or a set of postive or negative points
        /// </param>
        public Sam2PromptSet(
            global::System.Collections.Generic.IList<global::G.Sam2Prompt>? prompts)
        {
            this.Prompts = prompts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2PromptSet" /> class.
        /// </summary>
        public Sam2PromptSet()
        {
        }
    }
}
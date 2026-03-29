//HintName: G.Models.PiiPostResponsesContentApplicationJsonSchemaChecksItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PiiPostResponsesContentApplicationJsonSchemaChecksItems
    {
        /// <summary>
        /// The index position in the collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The prompt that was checked for PII. Only returned if no PII is present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The new prompt with the replaced information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_prompt")]
        public string? NewPrompt { get; set; }

        /// <summary>
        /// An array of PII metadata objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pii_type_and_positions")]
        public global::System.Collections.Generic.IList<global::G.PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems>? PiiTypeAndPositions { get; set; }

        /// <summary>
        /// The response if this choice was successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiPostResponsesContentApplicationJsonSchemaChecksItems" /> class.
        /// </summary>
        /// <param name="index">
        /// The index position in the collection.
        /// </param>
        /// <param name="prompt">
        /// The prompt that was checked for PII. Only returned if no PII is present.
        /// </param>
        /// <param name="newPrompt">
        /// The new prompt with the replaced information.
        /// </param>
        /// <param name="piiTypeAndPositions">
        /// An array of PII metadata objects
        /// </param>
        /// <param name="status">
        /// The response if this choice was successful.
        /// </param>
        public PiiPostResponsesContentApplicationJsonSchemaChecksItems(
            int? index,
            string? prompt,
            string? newPrompt,
            global::System.Collections.Generic.IList<global::G.PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems>? piiTypeAndPositions,
            string? status)
        {
            this.Index = index;
            this.Prompt = prompt;
            this.NewPrompt = newPrompt;
            this.PiiTypeAndPositions = piiTypeAndPositions;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiPostResponsesContentApplicationJsonSchemaChecksItems" /> class.
        /// </summary>
        public PiiPostResponsesContentApplicationJsonSchemaChecksItems()
        {
        }
    }
}
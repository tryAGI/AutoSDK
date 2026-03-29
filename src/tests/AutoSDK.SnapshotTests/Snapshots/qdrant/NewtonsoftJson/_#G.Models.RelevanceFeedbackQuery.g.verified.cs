//HintName: G.Models.RelevanceFeedbackQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelevanceFeedbackQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relevance_feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RelevanceFeedbackInput RelevanceFeedback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelevanceFeedbackQuery" /> class.
        /// </summary>
        /// <param name="relevanceFeedback"></param>
        public RelevanceFeedbackQuery(
            global::G.RelevanceFeedbackInput relevanceFeedback)
        {
            this.RelevanceFeedback = relevanceFeedback ?? throw new global::System.ArgumentNullException(nameof(relevanceFeedback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelevanceFeedbackQuery" /> class.
        /// </summary>
        public RelevanceFeedbackQuery()
        {
        }
    }
}
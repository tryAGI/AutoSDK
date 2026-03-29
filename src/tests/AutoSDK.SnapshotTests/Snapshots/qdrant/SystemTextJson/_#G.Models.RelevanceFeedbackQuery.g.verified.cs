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
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RelevanceFeedbackInput RelevanceFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelevanceFeedbackQuery" /> class.
        /// </summary>
        /// <param name="relevanceFeedback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
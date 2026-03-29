//HintName: G.Models.UtteranceHallucination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UtteranceHallucination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hallucinations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Hallucination> Hallucinations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceHallucination" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="hallucinations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceHallucination(
            double responseId,
            global::System.Collections.Generic.IList<global::G.Hallucination> hallucinations)
        {
            this.ResponseId = responseId;
            this.Hallucinations = hallucinations ?? throw new global::System.ArgumentNullException(nameof(hallucinations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceHallucination" /> class.
        /// </summary>
        public UtteranceHallucination()
        {
        }
    }
}
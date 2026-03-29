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
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double ResponseId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hallucinations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Hallucination> Hallucinations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceHallucination" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="hallucinations"></param>
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
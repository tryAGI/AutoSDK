//HintName: G.Models.MistranscribedImportantEntitiesAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MistranscribedImportantEntitiesAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UtteranceMistranscribedImportantEntities> Details { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mie_utterance_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double MieUtteranceCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_utterance_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalUtteranceCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MistranscribedImportantEntitiesAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="mieUtteranceCount"></param>
        /// <param name="totalUtteranceCount"></param>
        public MistranscribedImportantEntitiesAnalysis(
            global::System.Collections.Generic.IList<global::G.UtteranceMistranscribedImportantEntities> details,
            double mieUtteranceCount,
            double totalUtteranceCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.MieUtteranceCount = mieUtteranceCount;
            this.TotalUtteranceCount = totalUtteranceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MistranscribedImportantEntitiesAnalysis" /> class.
        /// </summary>
        public MistranscribedImportantEntitiesAnalysis()
        {
        }
    }
}
//HintName: G.Models.FTModelCapabilitiesOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FTModelCapabilitiesOut
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_chat")]
        public bool? CompletionChat { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_fim")]
        public bool? CompletionFim { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fine_tuning")]
        public bool? FineTuning { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_calling")]
        public bool? FunctionCalling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FTModelCapabilitiesOut" /> class.
        /// </summary>
        /// <param name="completionChat">
        /// Default Value: true
        /// </param>
        /// <param name="completionFim">
        /// Default Value: false
        /// </param>
        /// <param name="fineTuning">
        /// Default Value: false
        /// </param>
        /// <param name="functionCalling">
        /// Default Value: false
        /// </param>
        public FTModelCapabilitiesOut(
            bool? completionChat,
            bool? completionFim,
            bool? fineTuning,
            bool? functionCalling)
        {
            this.CompletionChat = completionChat;
            this.CompletionFim = completionFim;
            this.FineTuning = fineTuning;
            this.FunctionCalling = functionCalling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FTModelCapabilitiesOut" /> class.
        /// </summary>
        public FTModelCapabilitiesOut()
        {
        }
    }
}
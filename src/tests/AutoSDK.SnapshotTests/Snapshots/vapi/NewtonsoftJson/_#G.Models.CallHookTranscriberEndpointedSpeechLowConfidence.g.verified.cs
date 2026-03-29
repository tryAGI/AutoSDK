//HintName: G.Models.CallHookTranscriberEndpointedSpeechLowConfidence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHookTranscriberEndpointedSpeechLowConfidence
    {
        /// <summary>
        /// This is the set of actions to perform when the hook triggers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> Do { get; set; } = default!;

        /// <summary>
        /// This is the event that triggers this hook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on", Required = global::Newtonsoft.Json.Required.Always)]
        public string On { get; set; } = default!;

        /// <summary>
        /// This is the options for the hook including confidence thresholds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.EndpointedSpeechLowConfidenceOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookTranscriberEndpointedSpeechLowConfidence" /> class.
        /// </summary>
        /// <param name="do">
        /// This is the set of actions to perform when the hook triggers
        /// </param>
        /// <param name="on">
        /// This is the event that triggers this hook
        /// </param>
        /// <param name="options">
        /// This is the options for the hook including confidence thresholds
        /// </param>
        public CallHookTranscriberEndpointedSpeechLowConfidence(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> @do,
            string on,
            global::G.EndpointedSpeechLowConfidenceOptions? options)
        {
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
            this.On = on ?? throw new global::System.ArgumentNullException(nameof(on));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookTranscriberEndpointedSpeechLowConfidence" /> class.
        /// </summary>
        public CallHookTranscriberEndpointedSpeechLowConfidence()
        {
        }
    }
}
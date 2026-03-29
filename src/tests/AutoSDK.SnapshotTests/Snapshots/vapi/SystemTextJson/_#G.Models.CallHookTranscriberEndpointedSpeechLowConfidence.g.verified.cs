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
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> Do { get; set; }

        /// <summary>
        /// This is the event that triggers this hook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string On { get; set; }

        /// <summary>
        /// This is the options for the hook including confidence thresholds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::G.EndpointedSpeechLowConfidenceOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
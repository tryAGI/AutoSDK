//HintName: G.Models.CallHookAssistantSpeechInterrupted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHookAssistantSpeechInterrupted
    {
        /// <summary>
        /// This is the event that triggers this hook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CallHookAssistantSpeechInterruptedOnJsonConverter))]
        public global::G.CallHookAssistantSpeechInterruptedOn On { get; set; }

        /// <summary>
        /// This is the set of actions to perform when the hook triggers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> Do { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookAssistantSpeechInterrupted" /> class.
        /// </summary>
        /// <param name="do">
        /// This is the set of actions to perform when the hook triggers
        /// </param>
        /// <param name="on">
        /// This is the event that triggers this hook
        /// </param>
        public CallHookAssistantSpeechInterrupted(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> @do,
            global::G.CallHookAssistantSpeechInterruptedOn on)
        {
            this.On = on;
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookAssistantSpeechInterrupted" /> class.
        /// </summary>
        public CallHookAssistantSpeechInterrupted()
        {
        }
    }
}
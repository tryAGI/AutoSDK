//HintName: G.Models.CallHookCustomerSpeechInterrupted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHookCustomerSpeechInterrupted
    {
        /// <summary>
        /// This is the event that triggers this hook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on")]
        public global::G.CallHookCustomerSpeechInterruptedOn On { get; set; }

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
        /// Initializes a new instance of the <see cref="CallHookCustomerSpeechInterrupted" /> class.
        /// </summary>
        /// <param name="do">
        /// This is the set of actions to perform when the hook triggers
        /// </param>
        /// <param name="on">
        /// This is the event that triggers this hook
        /// </param>
        public CallHookCustomerSpeechInterrupted(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> @do,
            global::G.CallHookCustomerSpeechInterruptedOn on)
        {
            this.On = on;
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookCustomerSpeechInterrupted" /> class.
        /// </summary>
        public CallHookCustomerSpeechInterrupted()
        {
        }
    }
}
//HintName: G.Models.CallHookCallEnding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHookCallEnding
    {
        /// <summary>
        /// This is the event that triggers this hook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on")]
        public global::G.CallHookCallEndingOn On { get; set; }

        /// <summary>
        /// This is the set of actions to perform when the hook triggers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolCallHookAction, global::G.MessageAddHookAction>> Do { get; set; } = default!;

        /// <summary>
        /// This is the set of filters that must match for the hook to trigger
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.CallHookFilter>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookCallEnding" /> class.
        /// </summary>
        /// <param name="do">
        /// This is the set of actions to perform when the hook triggers
        /// </param>
        /// <param name="on">
        /// This is the event that triggers this hook
        /// </param>
        /// <param name="filters">
        /// This is the set of filters that must match for the hook to trigger
        /// </param>
        public CallHookCallEnding(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolCallHookAction, global::G.MessageAddHookAction>> @do,
            global::G.CallHookCallEndingOn on,
            global::System.Collections.Generic.IList<global::G.CallHookFilter>? filters)
        {
            this.On = on;
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookCallEnding" /> class.
        /// </summary>
        public CallHookCallEnding()
        {
        }
    }
}
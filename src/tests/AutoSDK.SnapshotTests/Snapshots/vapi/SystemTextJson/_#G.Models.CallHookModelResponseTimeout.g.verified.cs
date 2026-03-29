//HintName: G.Models.CallHookModelResponseTimeout.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHookModelResponseTimeout
    {
        /// <summary>
        /// This is the event that triggers this hook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CallHookModelResponseTimeoutOnJsonConverter))]
        public global::G.CallHookModelResponseTimeoutOn On { get; set; }

        /// <summary>
        /// This is the set of actions to perform when the hook triggers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> Do { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookModelResponseTimeout" /> class.
        /// </summary>
        /// <param name="do">
        /// This is the set of actions to perform when the hook triggers
        /// </param>
        /// <param name="on">
        /// This is the event that triggers this hook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHookModelResponseTimeout(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> @do,
            global::G.CallHookModelResponseTimeoutOn on)
        {
            this.On = on;
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookModelResponseTimeout" /> class.
        /// </summary>
        public CallHookModelResponseTimeout()
        {
        }
    }
}
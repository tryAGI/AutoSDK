//HintName: G.Models.CallHookCustomerSpeechTimeout.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHookCustomerSpeechTimeout
    {
        /// <summary>
        /// Must be either "customer.speech.timeout" or match the pattern "customer.speech.timeout[property=value]"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on", Required = global::Newtonsoft.Json.Required.Always)]
        public string On { get; set; } = default!;

        /// <summary>
        /// This is the set of actions to perform when the hook triggers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> Do { get; set; } = default!;

        /// <summary>
        /// This is the set of filters that must match for the hook to trigger
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.CustomerSpeechTimeoutOptions? Options { get; set; }

        /// <summary>
        /// This is the name of the hook, it can be set by the user to identify the hook.<br/>
        /// If no name is provided, the hook will be auto generated as UUID.<br/>
        /// @default UUID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookCustomerSpeechTimeout" /> class.
        /// </summary>
        /// <param name="on">
        /// Must be either "customer.speech.timeout" or match the pattern "customer.speech.timeout[property=value]"
        /// </param>
        /// <param name="do">
        /// This is the set of actions to perform when the hook triggers
        /// </param>
        /// <param name="options">
        /// This is the set of filters that must match for the hook to trigger
        /// </param>
        /// <param name="name">
        /// This is the name of the hook, it can be set by the user to identify the hook.<br/>
        /// If no name is provided, the hook will be auto generated as UUID.<br/>
        /// @default UUID
        /// </param>
        public CallHookCustomerSpeechTimeout(
            string on,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SayHookAction, global::G.ToolCallHookAction, global::G.MessageAddHookAction>> @do,
            global::G.CustomerSpeechTimeoutOptions? options,
            string? name)
        {
            this.On = on ?? throw new global::System.ArgumentNullException(nameof(on));
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
            this.Options = options;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookCustomerSpeechTimeout" /> class.
        /// </summary>
        public CallHookCustomerSpeechTimeout()
        {
        }
    }
}
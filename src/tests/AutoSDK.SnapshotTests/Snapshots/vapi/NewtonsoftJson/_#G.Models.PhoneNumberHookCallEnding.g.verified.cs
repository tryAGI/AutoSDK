//HintName: G.Models.PhoneNumberHookCallEnding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberHookCallEnding
    {
        /// <summary>
        /// This is the event to trigger the hook on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PhoneNumberHookCallEndingOnJsonConverter))]
        public global::G.PhoneNumberHookCallEndingOn On { get; set; }

        /// <summary>
        /// Optional filters to decide when to trigger - restricted to assistant-request related ended reasons
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.PhoneNumberCallEndingHookFilter>? Filters { get; set; }

        /// <summary>
        /// This is the action to perform when the hook triggers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do")]
        public global::G.OneOf<global::G.TransferPhoneNumberHookAction, global::G.SayPhoneNumberHookAction>? Do { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberHookCallEnding" /> class.
        /// </summary>
        /// <param name="on">
        /// This is the event to trigger the hook on
        /// </param>
        /// <param name="filters">
        /// Optional filters to decide when to trigger - restricted to assistant-request related ended reasons
        /// </param>
        /// <param name="do">
        /// This is the action to perform when the hook triggers
        /// </param>
        public PhoneNumberHookCallEnding(
            global::G.PhoneNumberHookCallEndingOn on,
            global::System.Collections.Generic.IList<global::G.PhoneNumberCallEndingHookFilter>? filters,
            global::G.OneOf<global::G.TransferPhoneNumberHookAction, global::G.SayPhoneNumberHookAction>? @do)
        {
            this.On = on;
            this.Filters = filters;
            this.Do = @do;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberHookCallEnding" /> class.
        /// </summary>
        public PhoneNumberHookCallEnding()
        {
        }
    }
}
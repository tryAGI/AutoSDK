//HintName: G.Models.SayPhoneNumberHookAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SayPhoneNumberHookAction
    {
        /// <summary>
        /// This is the type of action - must be "say"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SayPhoneNumberHookActionType Type { get; set; }

        /// <summary>
        /// This is the message to say
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exact", Required = global::Newtonsoft.Json.Required.Always)]
        public string Exact { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SayPhoneNumberHookAction" /> class.
        /// </summary>
        /// <param name="exact">
        /// This is the message to say
        /// </param>
        /// <param name="type">
        /// This is the type of action - must be "say"
        /// </param>
        public SayPhoneNumberHookAction(
            string exact,
            global::G.SayPhoneNumberHookActionType type)
        {
            this.Type = type;
            this.Exact = exact ?? throw new global::System.ArgumentNullException(nameof(exact));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SayPhoneNumberHookAction" /> class.
        /// </summary>
        public SayPhoneNumberHookAction()
        {
        }
    }
}
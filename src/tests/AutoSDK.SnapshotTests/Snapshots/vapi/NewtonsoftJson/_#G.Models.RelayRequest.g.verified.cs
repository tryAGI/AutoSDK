//HintName: G.Models.RelayRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelayRequest
    {
        /// <summary>
        /// The source identifier of the relay request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public string Source { get; set; } = default!;

        /// <summary>
        /// The target assistant or squad to relay the commands to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.RelayTargetAssistant, global::G.RelayTargetSquad> Target { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the customer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customerId", Required = global::Newtonsoft.Json.Required.Always)]
        public string CustomerId { get; set; } = default!;

        /// <summary>
        /// The list of commands to relay to the target
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commands", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.RelayCommandSay, global::G.RelayCommandNote>> Commands { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayRequest" /> class.
        /// </summary>
        /// <param name="source">
        /// The source identifier of the relay request
        /// </param>
        /// <param name="target">
        /// The target assistant or squad to relay the commands to
        /// </param>
        /// <param name="customerId">
        /// The unique identifier of the customer
        /// </param>
        /// <param name="commands">
        /// The list of commands to relay to the target
        /// </param>
        public RelayRequest(
            string source,
            global::G.OneOf<global::G.RelayTargetAssistant, global::G.RelayTargetSquad> target,
            string customerId,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.RelayCommandSay, global::G.RelayCommandNote>> commands)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target;
            this.CustomerId = customerId ?? throw new global::System.ArgumentNullException(nameof(customerId));
            this.Commands = commands ?? throw new global::System.ArgumentNullException(nameof(commands));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayRequest" /> class.
        /// </summary>
        public RelayRequest()
        {
        }
    }
}
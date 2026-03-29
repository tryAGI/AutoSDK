//HintName: G.Models.TransferFallbackPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferFallbackPlan
    {
        /// <summary>
        /// This is the message the assistant will deliver to the customer if the transfer fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::G.CustomMessage> Message { get; set; } = default!;

        /// <summary>
        /// This controls what happens after delivering the failure message to the customer.<br/>
        /// - true: End the call after delivering the failure message (default)<br/>
        /// - false: Keep the assistant on the call to continue handling the customer's request<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endCallEnabled")]
        public bool? EndCallEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFallbackPlan" /> class.
        /// </summary>
        /// <param name="message">
        /// This is the message the assistant will deliver to the customer if the transfer fails.
        /// </param>
        /// <param name="endCallEnabled">
        /// This controls what happens after delivering the failure message to the customer.<br/>
        /// - true: End the call after delivering the failure message (default)<br/>
        /// - false: Keep the assistant on the call to continue handling the customer's request<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </param>
        public TransferFallbackPlan(
            global::G.OneOf<string, global::G.CustomMessage> message,
            bool? endCallEnabled)
        {
            this.Message = message;
            this.EndCallEnabled = endCallEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFallbackPlan" /> class.
        /// </summary>
        public TransferFallbackPlan()
        {
        }
    }
}
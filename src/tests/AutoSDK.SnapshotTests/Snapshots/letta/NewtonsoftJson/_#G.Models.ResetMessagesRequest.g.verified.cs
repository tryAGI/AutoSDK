//HintName: G.Models.ResetMessagesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for resetting messages on an agent.
    /// </summary>
    public sealed partial class ResetMessagesRequest
    {
        /// <summary>
        /// If true, adds the default initial messages after resetting.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_default_initial_messages")]
        public bool? AddDefaultInitialMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetMessagesRequest" /> class.
        /// </summary>
        /// <param name="addDefaultInitialMessages">
        /// If true, adds the default initial messages after resetting.<br/>
        /// Default Value: false
        /// </param>
        public ResetMessagesRequest(
            bool? addDefaultInitialMessages)
        {
            this.AddDefaultInitialMessages = addDefaultInitialMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetMessagesRequest" /> class.
        /// </summary>
        public ResetMessagesRequest()
        {
        }
    }
}
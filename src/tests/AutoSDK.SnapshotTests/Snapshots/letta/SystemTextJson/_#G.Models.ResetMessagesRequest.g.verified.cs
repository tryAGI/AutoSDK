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
        [global::System.Text.Json.Serialization.JsonPropertyName("add_default_initial_messages")]
        public bool? AddDefaultInitialMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetMessagesRequest" /> class.
        /// </summary>
        /// <param name="addDefaultInitialMessages">
        /// If true, adds the default initial messages after resetting.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
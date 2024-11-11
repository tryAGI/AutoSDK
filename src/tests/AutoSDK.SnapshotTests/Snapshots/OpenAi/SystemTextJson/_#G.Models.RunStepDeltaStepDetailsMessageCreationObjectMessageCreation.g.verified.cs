//HintName: G.Models.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsMessageCreationObjectMessageCreation
    {
        /// <summary>
        /// The ID of the message that was created by this run step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsMessageCreationObjectMessageCreation" /> class.
        /// </summary>
        /// <param name="messageId">
        /// The ID of the message that was created by this run step.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDeltaStepDetailsMessageCreationObjectMessageCreation(
            string? messageId)
        {
            this.MessageId = messageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsMessageCreationObjectMessageCreation" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsMessageCreationObjectMessageCreation()
        {
        }
    }
}
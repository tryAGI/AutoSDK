//HintName: G.Models.RunStepDetailsMessageCreationObjectMessageCreation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsMessageCreationObjectMessageCreation
    {
        /// <summary>
        /// The ID of the message that was created by this run step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsMessageCreationObjectMessageCreation" /> class.
        /// </summary>
        /// <param name="messageId">
        /// The ID of the message that was created by this run step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDetailsMessageCreationObjectMessageCreation(
            string messageId)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsMessageCreationObjectMessageCreation" /> class.
        /// </summary>
        public RunStepDetailsMessageCreationObjectMessageCreation()
        {
        }
    }
}
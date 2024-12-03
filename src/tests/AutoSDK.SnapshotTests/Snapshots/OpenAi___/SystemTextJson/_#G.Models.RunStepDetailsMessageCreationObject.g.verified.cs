//HintName: G.Models.RunStepDetailsMessageCreationObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the message creation by the run step.
    /// </summary>
    public sealed partial class RunStepDetailsMessageCreationObject
    {
        /// <summary>
        /// Always `message_creation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter))]
        public global::G.RunStepDetailsMessageCreationObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunStepDetailsMessageCreationObjectMessageCreation MessageCreation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsMessageCreationObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `message_creation`.
        /// </param>
        /// <param name="messageCreation"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDetailsMessageCreationObject(
            global::G.RunStepDetailsMessageCreationObjectMessageCreation messageCreation,
            global::G.RunStepDetailsMessageCreationObjectType type)
        {
            this.MessageCreation = messageCreation ?? throw new global::System.ArgumentNullException(nameof(messageCreation));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsMessageCreationObject" /> class.
        /// </summary>
        public RunStepDetailsMessageCreationObject()
        {
        }
    }
}
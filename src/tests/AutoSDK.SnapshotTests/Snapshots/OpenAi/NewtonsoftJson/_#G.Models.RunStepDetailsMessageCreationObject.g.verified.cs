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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDetailsMessageCreationObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_creation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDetailsMessageCreationObjectMessageCreation MessageCreation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsMessageCreationObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `message_creation`.
        /// </param>
        /// <param name="messageCreation"></param>
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
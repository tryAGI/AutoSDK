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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RunStepDetailsMessageCreationObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RunStepDetailsMessageCreationObjectMessageCreation MessageCreation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
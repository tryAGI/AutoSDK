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
    }
}
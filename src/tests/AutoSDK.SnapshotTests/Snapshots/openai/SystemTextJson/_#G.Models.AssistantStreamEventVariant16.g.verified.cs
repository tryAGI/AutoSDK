//HintName: G.Models.AssistantStreamEventVariant16.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when parts of a [run step](/docs/api-reference/run-steps/step-object) are being streamed.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant16
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantStreamEventVariant16EventJsonConverter))]
        public global::G.AssistantStreamEventVariant16Event Event { get; set; }

        /// <summary>
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunStepDeltaObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant16" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantStreamEventVariant16(
            global::G.RunStepDeltaObject data,
            global::G.AssistantStreamEventVariant16Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant16" /> class.
        /// </summary>
        public AssistantStreamEventVariant16()
        {
        }
    }
}
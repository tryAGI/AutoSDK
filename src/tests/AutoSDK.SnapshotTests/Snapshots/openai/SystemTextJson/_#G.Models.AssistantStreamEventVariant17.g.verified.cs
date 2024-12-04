//HintName: G.Models.AssistantStreamEventVariant17.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is completed.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant17
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantStreamEventVariant17EventJsonConverter))]
        public global::G.AssistantStreamEventVariant17Event Event { get; set; }

        /// <summary>
        /// Represents a step in execution of a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunStepObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant17" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a step in execution of a run.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AssistantStreamEventVariant17(
            global::G.RunStepObject data,
            global::G.AssistantStreamEventVariant17Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant17" /> class.
        /// </summary>
        public AssistantStreamEventVariant17()
        {
        }
    }
}
//HintName: G.Models.RunStepStreamEventVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) fails.
    /// </summary>
    public sealed partial class RunStepStreamEventVariant5
    {
        /// <summary>
        /// Represents a step in execution of a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunStepObject Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStepStreamEventVariant5EventJsonConverter))]
        public global::G.RunStepStreamEventVariant5Event Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant5" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a step in execution of a run.
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepStreamEventVariant5(
            global::G.RunStepObject data,
            global::G.RunStepStreamEventVariant5Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant5" /> class.
        /// </summary>
        public RunStepStreamEventVariant5()
        {
        }
    }
}
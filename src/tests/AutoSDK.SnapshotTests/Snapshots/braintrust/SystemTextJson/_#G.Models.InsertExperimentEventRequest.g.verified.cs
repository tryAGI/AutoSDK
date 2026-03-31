//HintName: G.Models.InsertExperimentEventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsertExperimentEventRequest
    {
        /// <summary>
        /// A list of experiment events to insert
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InsertExperimentEvent> Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertExperimentEventRequest" /> class.
        /// </summary>
        /// <param name="events">
        /// A list of experiment events to insert
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsertExperimentEventRequest(
            global::System.Collections.Generic.IList<global::G.InsertExperimentEvent> events)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertExperimentEventRequest" /> class.
        /// </summary>
        public InsertExperimentEventRequest()
        {
        }
    }
}
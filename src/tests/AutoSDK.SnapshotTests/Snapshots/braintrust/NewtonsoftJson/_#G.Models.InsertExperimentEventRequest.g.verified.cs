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
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InsertExperimentEvent> Events { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertExperimentEventRequest" /> class.
        /// </summary>
        /// <param name="events">
        /// A list of experiment events to insert
        /// </param>
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
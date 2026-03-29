//HintName: G.Models.InsertProjectLogsEventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsertProjectLogsEventRequest
    {
        /// <summary>
        /// A list of project logs events to insert
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InsertProjectLogsEvent> Events { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertProjectLogsEventRequest" /> class.
        /// </summary>
        /// <param name="events">
        /// A list of project logs events to insert
        /// </param>
        public InsertProjectLogsEventRequest(
            global::System.Collections.Generic.IList<global::G.InsertProjectLogsEvent> events)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertProjectLogsEventRequest" /> class.
        /// </summary>
        public InsertProjectLogsEventRequest()
        {
        }
    }
}
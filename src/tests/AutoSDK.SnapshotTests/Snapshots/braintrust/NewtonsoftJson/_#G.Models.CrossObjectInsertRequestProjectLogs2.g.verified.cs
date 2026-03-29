//HintName: G.Models.CrossObjectInsertRequestProjectLogs2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrossObjectInsertRequestProjectLogs2
    {
        /// <summary>
        /// A list of project logs events to insert
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.InsertProjectLogsEvent>? Events { get; set; }

        /// <summary>
        /// A list of project logs feedback items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback")]
        public global::System.Collections.Generic.IList<global::G.FeedbackProjectLogsItem>? Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertRequestProjectLogs2" /> class.
        /// </summary>
        /// <param name="events">
        /// A list of project logs events to insert
        /// </param>
        /// <param name="feedback">
        /// A list of project logs feedback items
        /// </param>
        public CrossObjectInsertRequestProjectLogs2(
            global::System.Collections.Generic.IList<global::G.InsertProjectLogsEvent>? events,
            global::System.Collections.Generic.IList<global::G.FeedbackProjectLogsItem>? feedback)
        {
            this.Events = events;
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertRequestProjectLogs2" /> class.
        /// </summary>
        public CrossObjectInsertRequestProjectLogs2()
        {
        }
    }
}
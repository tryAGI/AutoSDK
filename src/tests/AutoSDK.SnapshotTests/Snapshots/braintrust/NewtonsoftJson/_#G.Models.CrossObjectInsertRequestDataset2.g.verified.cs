//HintName: G.Models.CrossObjectInsertRequestDataset2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrossObjectInsertRequestDataset2
    {
        /// <summary>
        /// A list of dataset events to insert
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.InsertDatasetEvent>? Events { get; set; }

        /// <summary>
        /// A list of dataset feedback items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback")]
        public global::System.Collections.Generic.IList<global::G.FeedbackDatasetItem>? Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertRequestDataset2" /> class.
        /// </summary>
        /// <param name="events">
        /// A list of dataset events to insert
        /// </param>
        /// <param name="feedback">
        /// A list of dataset feedback items
        /// </param>
        public CrossObjectInsertRequestDataset2(
            global::System.Collections.Generic.IList<global::G.InsertDatasetEvent>? events,
            global::System.Collections.Generic.IList<global::G.FeedbackDatasetItem>? feedback)
        {
            this.Events = events;
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertRequestDataset2" /> class.
        /// </summary>
        public CrossObjectInsertRequestDataset2()
        {
        }
    }
}
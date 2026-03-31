//HintName: G.Models.CrossObjectInsertResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrossObjectInsertResponse
    {
        /// <summary>
        /// A mapping from experiment id to row ids for inserted `events`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment")]
        public global::System.Collections.Generic.Dictionary<string, global::G.InsertEventsResponse>? Experiment { get; set; }

        /// <summary>
        /// A mapping from dataset id to row ids for inserted `events`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        public global::System.Collections.Generic.Dictionary<string, global::G.InsertEventsResponse>? Dataset { get; set; }

        /// <summary>
        /// A mapping from project id to row ids for inserted `events`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_logs")]
        public global::System.Collections.Generic.Dictionary<string, global::G.InsertEventsResponse>? ProjectLogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertResponse" /> class.
        /// </summary>
        /// <param name="experiment">
        /// A mapping from experiment id to row ids for inserted `events`
        /// </param>
        /// <param name="dataset">
        /// A mapping from dataset id to row ids for inserted `events`
        /// </param>
        /// <param name="projectLogs">
        /// A mapping from project id to row ids for inserted `events`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrossObjectInsertResponse(
            global::System.Collections.Generic.Dictionary<string, global::G.InsertEventsResponse>? experiment,
            global::System.Collections.Generic.Dictionary<string, global::G.InsertEventsResponse>? dataset,
            global::System.Collections.Generic.Dictionary<string, global::G.InsertEventsResponse>? projectLogs)
        {
            this.Experiment = experiment;
            this.Dataset = dataset;
            this.ProjectLogs = projectLogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertResponse" /> class.
        /// </summary>
        public CrossObjectInsertResponse()
        {
        }
    }
}
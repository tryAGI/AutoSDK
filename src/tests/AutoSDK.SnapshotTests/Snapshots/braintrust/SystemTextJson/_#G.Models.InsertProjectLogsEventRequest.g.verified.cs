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
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InsertProjectLogsEvent> Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertProjectLogsEventRequest" /> class.
        /// </summary>
        /// <param name="events">
        /// A list of project logs events to insert
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
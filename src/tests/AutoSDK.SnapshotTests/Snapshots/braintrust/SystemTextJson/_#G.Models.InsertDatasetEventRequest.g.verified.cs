//HintName: G.Models.InsertDatasetEventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsertDatasetEventRequest
    {
        /// <summary>
        /// A list of dataset events to insert
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InsertDatasetEvent> Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDatasetEventRequest" /> class.
        /// </summary>
        /// <param name="events">
        /// A list of dataset events to insert
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsertDatasetEventRequest(
            global::System.Collections.Generic.IList<global::G.InsertDatasetEvent> events)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDatasetEventRequest" /> class.
        /// </summary>
        public InsertDatasetEventRequest()
        {
        }
    }
}
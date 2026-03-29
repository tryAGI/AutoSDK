//HintName: G.Models.JSONQueryOnEventsTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONQueryOnEventsTable
    {
        /// <summary>
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </summary>
        /// <example>vapiql-json</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.JSONQueryOnEventsTableType Type { get; set; }

        /// <summary>
        /// This is the table that will be queried.<br/>
        /// Must be "events" for event-based insights.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table")]
        public global::G.JSONQueryOnEventsTableTable Table { get; set; }

        /// <summary>
        /// The event type to query<br/>
        /// Example: assistant.model.requestFailed
        /// </summary>
        /// <example>assistant.model.requestFailed</example>
        [global::Newtonsoft.Json.JsonProperty("on", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JSONQueryOnEventsTableOn On { get; set; } = default!;

        /// <summary>
        /// This is the operation to perform on matching events.<br/>
        /// - "count": Returns the raw count of matching events<br/>
        /// - "percentage": Returns (count of matching events / total calls) * 100<br/>
        /// Example: count
        /// </summary>
        /// <example>count</example>
        [global::Newtonsoft.Json.JsonProperty("operation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JSONQueryOnEventsTableOperation Operation { get; set; } = default!;

        /// <summary>
        /// These are the filters to apply to the events query.<br/>
        /// Each filter filters on a field specific to the event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.EventsTableStringCondition, global::G.EventsTableNumberCondition, global::G.EventsTableBooleanCondition>>? Filters { get; set; }

        /// <summary>
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Model Failures
        /// </summary>
        /// <example>Model Failures</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONQueryOnEventsTable" /> class.
        /// </summary>
        /// <param name="on">
        /// The event type to query<br/>
        /// Example: assistant.model.requestFailed
        /// </param>
        /// <param name="operation">
        /// This is the operation to perform on matching events.<br/>
        /// - "count": Returns the raw count of matching events<br/>
        /// - "percentage": Returns (count of matching events / total calls) * 100<br/>
        /// Example: count
        /// </param>
        /// <param name="type">
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </param>
        /// <param name="table">
        /// This is the table that will be queried.<br/>
        /// Must be "events" for event-based insights.
        /// </param>
        /// <param name="filters">
        /// These are the filters to apply to the events query.<br/>
        /// Each filter filters on a field specific to the event type.
        /// </param>
        /// <param name="name">
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Model Failures
        /// </param>
        public JSONQueryOnEventsTable(
            global::G.JSONQueryOnEventsTableOn on,
            global::G.JSONQueryOnEventsTableOperation operation,
            global::G.JSONQueryOnEventsTableType type,
            global::G.JSONQueryOnEventsTableTable table,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.EventsTableStringCondition, global::G.EventsTableNumberCondition, global::G.EventsTableBooleanCondition>>? filters,
            string? name)
        {
            this.Type = type;
            this.Table = table;
            this.On = on;
            this.Operation = operation;
            this.Filters = filters;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONQueryOnEventsTable" /> class.
        /// </summary>
        public JSONQueryOnEventsTable()
        {
        }
    }
}
//HintName: G.Models.InvokeParentSpanParentStruct.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Span parent properties
    /// </summary>
    public sealed partial class InvokeParentSpanParentStruct
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InvokeParentSpanParentStructObjectTypeJsonConverter))]
        public global::G.InvokeParentSpanParentStructObjectType ObjectType { get; set; } = default!;

        /// <summary>
        /// The id of the container object you are logging to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// Identifiers for the row to to log a subspan under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("row_ids")]
        public global::G.InvokeParentSpanParentStructRowIds? RowIds { get; set; }

        /// <summary>
        /// Include these properties in every span created under this parent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("propagated_event")]
        public global::System.Collections.Generic.Dictionary<string, object?>? PropagatedEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeParentSpanParentStruct" /> class.
        /// </summary>
        /// <param name="objectType"></param>
        /// <param name="objectId">
        /// The id of the container object you are logging to
        /// </param>
        /// <param name="rowIds">
        /// Identifiers for the row to to log a subspan under
        /// </param>
        /// <param name="propagatedEvent">
        /// Include these properties in every span created under this parent
        /// </param>
        public InvokeParentSpanParentStruct(
            global::G.InvokeParentSpanParentStructObjectType objectType,
            string objectId,
            global::G.InvokeParentSpanParentStructRowIds? rowIds,
            global::System.Collections.Generic.Dictionary<string, object?>? propagatedEvent)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.RowIds = rowIds;
            this.PropagatedEvent = propagatedEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeParentSpanParentStruct" /> class.
        /// </summary>
        public InvokeParentSpanParentStruct()
        {
        }
    }
}
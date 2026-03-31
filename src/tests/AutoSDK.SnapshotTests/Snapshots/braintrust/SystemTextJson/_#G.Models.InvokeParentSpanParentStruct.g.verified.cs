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
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InvokeParentSpanParentStructObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InvokeParentSpanParentStructObjectType ObjectType { get; set; }

        /// <summary>
        /// The id of the container object you are logging to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// Identifiers for the row to to log a subspan under
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_ids")]
        public global::G.InvokeParentSpanParentStructRowIds? RowIds { get; set; }

        /// <summary>
        /// Include these properties in every span created under this parent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagated_event")]
        public global::System.Collections.Generic.Dictionary<string, object?>? PropagatedEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
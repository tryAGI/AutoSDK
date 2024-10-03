//HintName: G.Models.BatchDeleteResponseResultsObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results for this specific Object.
    /// </summary>
    public sealed partial class BatchDeleteResponseResultsObject
    {
        /// <summary>
        /// ID of the Object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Default Value: SUCCESS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchDeleteResponseResultsObjectStatusJsonConverter))]
        public global::G.BatchDeleteResponseResultsObjectStatus? Status { get; set; } = global::G.BatchDeleteResponseResultsObjectStatus.SUCCESS;

        /// <summary>
        /// An error response given by Weaviate end-points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::G.ErrorResponse? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
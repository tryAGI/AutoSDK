﻿//HintName: G.Models.BatchDeleteResponseResultsObject.g.cs

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
        public global::G.BatchDeleteResponseResultsObjectStatus? Status { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponseResultsObject" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the Object.
        /// </param>
        /// <param name="status">
        /// Default Value: SUCCESS
        /// </param>
        /// <param name="errors">
        /// An error response given by Weaviate end-points.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDeleteResponseResultsObject(
            global::System.Guid? id,
            global::G.BatchDeleteResponseResultsObjectStatus? status,
            global::G.ErrorResponse? errors)
        {
            this.Id = id;
            this.Status = status;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponseResultsObject" /> class.
        /// </summary>
        public BatchDeleteResponseResultsObject()
        {
        }
    }
}
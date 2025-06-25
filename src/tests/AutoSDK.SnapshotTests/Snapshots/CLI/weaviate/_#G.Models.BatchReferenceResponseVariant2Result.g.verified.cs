﻿//HintName: G.Models.BatchReferenceResponseVariant2Result.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results for this specific reference.
    /// </summary>
    public sealed partial class BatchReferenceResponseVariant2Result
    {
        /// <summary>
        /// Default Value: SUCCESS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchReferenceResponseVariant2ResultStatusJsonConverter))]
        public global::G.BatchReferenceResponseVariant2ResultStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="BatchReferenceResponseVariant2Result" /> class.
        /// </summary>
        /// <param name="status">
        /// Default Value: SUCCESS
        /// </param>
        /// <param name="errors">
        /// An error response given by Weaviate end-points.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchReferenceResponseVariant2Result(
            global::G.BatchReferenceResponseVariant2ResultStatus? status,
            global::G.ErrorResponse? errors)
        {
            this.Status = status;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReferenceResponseVariant2Result" /> class.
        /// </summary>
        public BatchReferenceResponseVariant2Result()
        {
        }
    }
}
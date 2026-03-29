//HintName: G.Models.BulkCreateEntityResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that represents the response from a bulk entity creation operation. This response summarizes the outcome, including the number of entities successfully created and any errors encountered during the process.
    /// </summary>
    public sealed partial class BulkCreateEntityResponse
    {
        /// <summary>
        /// The number of entities that were successfully created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_count")]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// The number of entities that failed to be created due to errors, such as missing assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        public int? FailedCount { get; set; }

        /// <summary>
        /// An array of objects representing the entities that were successfully created. Each object includes the unique identifier, name, and current status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::G.BulkCreateEntityResponseEntitiesItems>? Entities { get; set; }

        /// <summary>
        /// An array of error objects for entities that failed to be created. Each error object provides details about the failure, including the index of the entity in the original request, the entity's name, and the reason for the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::G.BulkCreateEntityResponseErrorsItems>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateEntityResponse" /> class.
        /// </summary>
        /// <param name="successCount">
        /// The number of entities that were successfully created.
        /// </param>
        /// <param name="failedCount">
        /// The number of entities that failed to be created due to errors, such as missing assets.
        /// </param>
        /// <param name="entities">
        /// An array of objects representing the entities that were successfully created. Each object includes the unique identifier, name, and current status.
        /// </param>
        /// <param name="errors">
        /// An array of error objects for entities that failed to be created. Each error object provides details about the failure, including the index of the entity in the original request, the entity's name, and the reason for the failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkCreateEntityResponse(
            int? successCount,
            int? failedCount,
            global::System.Collections.Generic.IList<global::G.BulkCreateEntityResponseEntitiesItems>? entities,
            global::System.Collections.Generic.IList<global::G.BulkCreateEntityResponseErrorsItems>? errors)
        {
            this.SuccessCount = successCount;
            this.FailedCount = failedCount;
            this.Entities = entities;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateEntityResponse" /> class.
        /// </summary>
        public BulkCreateEntityResponse()
        {
        }
    }
}
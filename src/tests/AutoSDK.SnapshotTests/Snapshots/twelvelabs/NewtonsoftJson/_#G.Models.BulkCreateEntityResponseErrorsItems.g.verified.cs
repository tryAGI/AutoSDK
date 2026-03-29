//HintName: G.Models.BulkCreateEntityResponseErrorsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkCreateEntityResponseErrorsItems
    {
        /// <summary>
        /// The zero-based index of the entity in the original request array. This helps identify which specific entity failed to be created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_index")]
        public int? EntityIndex { get; set; }

        /// <summary>
        /// The name of the entity that failed to be created, as provided in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_name")]
        public string? EntityName { get; set; }

        /// <summary>
        /// A message explaining why the entity failed to be created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_reason")]
        public string? ErrorReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateEntityResponseErrorsItems" /> class.
        /// </summary>
        /// <param name="entityIndex">
        /// The zero-based index of the entity in the original request array. This helps identify which specific entity failed to be created.
        /// </param>
        /// <param name="entityName">
        /// The name of the entity that failed to be created, as provided in the request.
        /// </param>
        /// <param name="errorReason">
        /// A message explaining why the entity failed to be created.
        /// </param>
        public BulkCreateEntityResponseErrorsItems(
            int? entityIndex,
            string? entityName,
            string? errorReason)
        {
            this.EntityIndex = entityIndex;
            this.EntityName = entityName;
            this.ErrorReason = errorReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateEntityResponseErrorsItems" /> class.
        /// </summary>
        public BulkCreateEntityResponseErrorsItems()
        {
        }
    }
}
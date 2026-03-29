//HintName: G.Models.Write.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create, update, or delete documents.
    /// </summary>
    public sealed partial class Write
    {
        /// <summary>
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upsert_columns")]
        public global::G.Columns? UpsertColumns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upsert_rows")]
        public global::System.Collections.Generic.IList<global::G.Row>? UpsertRows { get; set; }

        /// <summary>
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch_columns")]
        public global::G.Columns? PatchColumns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch_rows")]
        public global::System.Collections.Generic.IList<global::G.Row>? PatchRows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletes")]
        public global::System.Collections.Generic.IList<global::G.Id>? Deletes { get; set; }

        /// <summary>
        /// A condition evaluated against the current value of each document targeted by an upsert write. Only documents that pass the condition are upserted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upsert_condition")]
        public object? UpsertCondition { get; set; }

        /// <summary>
        /// A condition evaluated against the current value of each document targeted by a patch write. Only documents that pass the condition are patched.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch_condition")]
        public object? PatchCondition { get; set; }

        /// <summary>
        /// A condition evaluated against the current value of each document targeted by a delete write. Only documents that pass the condition are deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_condition")]
        public object? DeleteCondition { get; set; }

        /// <summary>
        /// A function used to calculate vector similarity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distance_metric")]
        public global::G.DistanceMetric? DistanceMetric { get; set; }

        /// <summary>
        /// The schema of the attributes attached to the documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("copy_from_namespace")]
        public global::G.OneOf<string, global::G.WriteCopyFromNamespace>? CopyFromNamespace { get; set; }

        /// <summary>
        /// The filter specifying which documents to delete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_by_filter")]
        public object? DeleteByFilter { get; set; }

        /// <summary>
        /// Allow partial completion when filter matches too many documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_by_filter_allow_partial")]
        public bool? DeleteByFilterAllowPartial { get; set; }

        /// <summary>
        /// The patch and filter specifying which documents to patch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch_by_filter")]
        public global::G.PatchByFilter? PatchByFilter { get; set; }

        /// <summary>
        /// Allow partial completion when filter matches too many documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch_by_filter_allow_partial")]
        public bool? PatchByFilterAllowPartial { get; set; }

        /// <summary>
        /// If true, return the IDs of affected rows (deleted, patched, upserted) in the response. For filtered and conditional writes, only IDs for writes that succeeded will be included.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_affected_ids")]
        public bool? ReturnAffectedIds { get; set; }

        /// <summary>
        /// The encryption configuration for a namespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encryption")]
        public global::G.Encryption2? Encryption { get; set; }

        /// <summary>
        /// Disables write throttling (HTTP 429 responses) during high-volume ingestion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_backpressure")]
        public bool? DisableBackpressure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Write" /> class.
        /// </summary>
        /// <param name="upsertColumns">
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </param>
        /// <param name="upsertRows"></param>
        /// <param name="patchColumns">
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </param>
        /// <param name="patchRows"></param>
        /// <param name="deletes"></param>
        /// <param name="upsertCondition">
        /// A condition evaluated against the current value of each document targeted by an upsert write. Only documents that pass the condition are upserted.
        /// </param>
        /// <param name="patchCondition">
        /// A condition evaluated against the current value of each document targeted by a patch write. Only documents that pass the condition are patched.
        /// </param>
        /// <param name="deleteCondition">
        /// A condition evaluated against the current value of each document targeted by a delete write. Only documents that pass the condition are deleted.
        /// </param>
        /// <param name="distanceMetric">
        /// A function used to calculate vector similarity.
        /// </param>
        /// <param name="schema">
        /// The schema of the attributes attached to the documents.
        /// </param>
        /// <param name="copyFromNamespace"></param>
        /// <param name="deleteByFilter">
        /// The filter specifying which documents to delete.
        /// </param>
        /// <param name="deleteByFilterAllowPartial">
        /// Allow partial completion when filter matches too many documents.
        /// </param>
        /// <param name="patchByFilter">
        /// The patch and filter specifying which documents to patch.
        /// </param>
        /// <param name="patchByFilterAllowPartial">
        /// Allow partial completion when filter matches too many documents.
        /// </param>
        /// <param name="returnAffectedIds">
        /// If true, return the IDs of affected rows (deleted, patched, upserted) in the response. For filtered and conditional writes, only IDs for writes that succeeded will be included.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encryption">
        /// The encryption configuration for a namespace.
        /// </param>
        /// <param name="disableBackpressure">
        /// Disables write throttling (HTTP 429 responses) during high-volume ingestion.
        /// </param>
        public Write(
            global::G.Columns? upsertColumns,
            global::System.Collections.Generic.IList<global::G.Row>? upsertRows,
            global::G.Columns? patchColumns,
            global::System.Collections.Generic.IList<global::G.Row>? patchRows,
            global::System.Collections.Generic.IList<global::G.Id>? deletes,
            object? upsertCondition,
            object? patchCondition,
            object? deleteCondition,
            global::G.DistanceMetric? distanceMetric,
            object? schema,
            global::G.OneOf<string, global::G.WriteCopyFromNamespace>? copyFromNamespace,
            object? deleteByFilter,
            bool? deleteByFilterAllowPartial,
            global::G.PatchByFilter? patchByFilter,
            bool? patchByFilterAllowPartial,
            bool? returnAffectedIds,
            global::G.Encryption2? encryption,
            bool? disableBackpressure)
        {
            this.UpsertColumns = upsertColumns;
            this.UpsertRows = upsertRows;
            this.PatchColumns = patchColumns;
            this.PatchRows = patchRows;
            this.Deletes = deletes;
            this.UpsertCondition = upsertCondition;
            this.PatchCondition = patchCondition;
            this.DeleteCondition = deleteCondition;
            this.DistanceMetric = distanceMetric;
            this.Schema = schema;
            this.CopyFromNamespace = copyFromNamespace;
            this.DeleteByFilter = deleteByFilter;
            this.DeleteByFilterAllowPartial = deleteByFilterAllowPartial;
            this.PatchByFilter = patchByFilter;
            this.PatchByFilterAllowPartial = patchByFilterAllowPartial;
            this.ReturnAffectedIds = returnAffectedIds;
            this.Encryption = encryption;
            this.DisableBackpressure = disableBackpressure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Write" /> class.
        /// </summary>
        public Write()
        {
        }
    }
}
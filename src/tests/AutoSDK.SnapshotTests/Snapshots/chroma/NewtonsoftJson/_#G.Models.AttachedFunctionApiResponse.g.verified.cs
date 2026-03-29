//HintName: G.Models.AttachedFunctionApiResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API response struct for attached function with function_name instead of function_id
    /// </summary>
    public sealed partial class AttachedFunctionApiResponse
    {
        /// <summary>
        /// Completion offset: the WAL position up to which the attached function has processed records
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_offset", Required = global::Newtonsoft.Json.Required.Always)]
        public long CompletionOffset { get; set; } = default!;

        /// <summary>
        /// Database name this attached function belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("database_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatabaseId { get; set; } = default!;

        /// <summary>
        /// Name of the function (e.g., "record_counter", "statistics")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FunctionName { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the attached function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Source collection that triggers the attached function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_collection_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid InputCollectionId { get; set; } = default!;

        /// <summary>
        /// Minimum number of new records required before the attached function runs again
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_records_for_invocation", Required = global::Newtonsoft.Json.Required.Always)]
        public long MinRecordsForInvocation { get; set; } = default!;

        /// <summary>
        /// Human-readable name for the attached function instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Name of target collection where attached function output is stored
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_collection", Required = global::Newtonsoft.Json.Required.Always)]
        public string OutputCollection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_collection_id")]
        public global::G.OneOf<object, global::System.Guid?>? OutputCollectionId { get; set; }

        /// <summary>
        /// Optional JSON parameters for the function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public string? Params { get; set; }

        /// <summary>
        /// Tenant name this attached function belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TenantId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedFunctionApiResponse" /> class.
        /// </summary>
        /// <param name="completionOffset">
        /// Completion offset: the WAL position up to which the attached function has processed records
        /// </param>
        /// <param name="databaseId">
        /// Database name this attached function belongs to
        /// </param>
        /// <param name="functionName">
        /// Name of the function (e.g., "record_counter", "statistics")
        /// </param>
        /// <param name="id">
        /// Unique identifier for the attached function
        /// </param>
        /// <param name="inputCollectionId">
        /// Source collection that triggers the attached function
        /// </param>
        /// <param name="minRecordsForInvocation">
        /// Minimum number of new records required before the attached function runs again
        /// </param>
        /// <param name="name">
        /// Human-readable name for the attached function instance
        /// </param>
        /// <param name="outputCollection">
        /// Name of target collection where attached function output is stored
        /// </param>
        /// <param name="tenantId">
        /// Tenant name this attached function belongs to
        /// </param>
        /// <param name="outputCollectionId"></param>
        /// <param name="params">
        /// Optional JSON parameters for the function
        /// </param>
        public AttachedFunctionApiResponse(
            long completionOffset,
            string databaseId,
            string functionName,
            global::System.Guid id,
            global::System.Guid inputCollectionId,
            long minRecordsForInvocation,
            string name,
            string outputCollection,
            string tenantId,
            global::G.OneOf<object, global::System.Guid?>? outputCollectionId,
            string? @params)
        {
            this.CompletionOffset = completionOffset;
            this.DatabaseId = databaseId ?? throw new global::System.ArgumentNullException(nameof(databaseId));
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
            this.Id = id;
            this.InputCollectionId = inputCollectionId;
            this.MinRecordsForInvocation = minRecordsForInvocation;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OutputCollection = outputCollection ?? throw new global::System.ArgumentNullException(nameof(outputCollection));
            this.OutputCollectionId = outputCollectionId;
            this.Params = @params;
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedFunctionApiResponse" /> class.
        /// </summary>
        public AttachedFunctionApiResponse()
        {
        }
    }
}
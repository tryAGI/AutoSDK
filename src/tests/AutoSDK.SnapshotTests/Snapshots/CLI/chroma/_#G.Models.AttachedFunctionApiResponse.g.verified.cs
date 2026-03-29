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
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CompletionOffset { get; set; }

        /// <summary>
        /// Database name this attached function belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatabaseId { get; set; }

        /// <summary>
        /// Name of the function (e.g., "record_counter", "statistics")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionName { get; set; }

        /// <summary>
        /// Unique identifier for the attached function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Source collection that triggers the attached function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_collection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InputCollectionId { get; set; }

        /// <summary>
        /// Minimum number of new records required before the attached function runs again
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_records_for_invocation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MinRecordsForInvocation { get; set; }

        /// <summary>
        /// Human-readable name for the attached function instance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Name of target collection where attached function output is stored
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_collection_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::System.Guid?>))]
        public global::G.OneOf<object, global::System.Guid?>? OutputCollectionId { get; set; }

        /// <summary>
        /// Optional JSON parameters for the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public string? Params { get; set; }

        /// <summary>
        /// Tenant name this attached function belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
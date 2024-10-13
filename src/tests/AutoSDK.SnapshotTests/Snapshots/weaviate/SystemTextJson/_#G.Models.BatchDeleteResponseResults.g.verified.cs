//HintName: G.Models.BatchDeleteResponseResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchDeleteResponseResults
    {
        /// <summary>
        /// How many objects were matched by the filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public double? Matches { get; set; }

        /// <summary>
        /// The most amount of objects that can be deleted in a single query, equals QUERY_MAXIMUM_RESULTS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// How many objects were successfully deleted in this round.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        public double? Successful { get; set; }

        /// <summary>
        /// How many objects should have been deleted but could not be deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public double? Failed { get; set; }

        /// <summary>
        /// With output set to "minimal" only objects with error occurred will the be described. Successfully deleted objects would be omitted. Output set to "verbose" will list all of the objets with their respective statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        public global::System.Collections.Generic.IList<global::G.BatchDeleteResponseResultsObject>? Objects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::G.BatchDeleteResponseResults? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BatchDeleteResponseResults),
                jsonSerializerContext) as global::G.BatchDeleteResponseResults;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BatchDeleteResponseResults? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BatchDeleteResponseResults>(
                json,
                jsonSerializerOptions);
        }

    }
}
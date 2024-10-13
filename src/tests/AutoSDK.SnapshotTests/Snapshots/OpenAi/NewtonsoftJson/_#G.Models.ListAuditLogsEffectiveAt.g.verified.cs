//HintName: G.Models.ListAuditLogsEffectiveAt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAuditLogsEffectiveAt
    {
        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is greater than this value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public int? Gt { get; set; }

        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is greater than or equal to this value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gte")]
        public int? Gte { get; set; }

        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is less than this value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public int? Lt { get; set; }

        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is less than or equal to this value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lte")]
        public int? Lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ListAuditLogsEffectiveAt? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListAuditLogsEffectiveAt>(
                json,
                jsonSerializerOptions);
        }

    }
}
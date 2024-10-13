//HintName: G.Models.BM25Config.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// tuning parameters for the BM25 algorithm
    /// </summary>
    public sealed partial class BM25Config
    {
        /// <summary>
        /// Calibrates term-weight scaling based on the term frequency within a document<br/>
        /// Default Value: 1.2F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("k1")]
        public float? K1 { get; set; } = 1.2F;

        /// <summary>
        /// Calibrates term-weight scaling based on the document length<br/>
        /// Default Value: 0.75F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("b")]
        public float? B { get; set; } = 0.75F;

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
        public static global::G.BM25Config? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BM25Config>(
                json,
                jsonSerializerOptions);
        }

    }
}
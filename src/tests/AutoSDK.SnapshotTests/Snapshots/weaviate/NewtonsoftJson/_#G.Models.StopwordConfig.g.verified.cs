//HintName: G.Models.StopwordConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// fine-grained control over stopword list usage
    /// </summary>
    public sealed partial class StopwordConfig
    {
        /// <summary>
        /// pre-existing list of common words by language<br/>
        /// Default Value: en
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preset")]
        public global::G.StopwordConfigPreset? Preset { get; set; } = global::G.StopwordConfigPreset.En;

        /// <summary>
        /// Stopwords to be considered additionally. Can be any array of custom strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additions")]
        public global::System.Collections.Generic.IList<string>? Additions { get; set; }

        /// <summary>
        /// stopwords to be removed from consideration. Can be any array of custom strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("removals")]
        public global::System.Collections.Generic.IList<string>? Removals { get; set; }

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
        public static global::G.StopwordConfig? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.StopwordConfig>(
                json,
                jsonSerializerOptions);
        }

    }
}
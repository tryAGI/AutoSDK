//HintName: G.Models.CodeScanningDefaultSetupUpdateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// You can use `run_url` to track the status of the run. This includes a property status and conclusion.<br/>
    /// You should not rely on this always being an actions workflow run object.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetupUpdateResponse
    {
        /// <summary>
        /// ID of the corresponding run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public int? RunId { get; set; }

        /// <summary>
        /// URL of the corresponding run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_url")]
        public string? RunUrl { get; set; }

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
        public static global::G.CodeScanningDefaultSetupUpdateResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningDefaultSetupUpdateResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
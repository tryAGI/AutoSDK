﻿//HintName: G.Models.CodeScanningDefaultSetupUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetupUpdate
    {
        /// <summary>
        /// The desired state of code scanning default setup.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.CodeScanningDefaultSetupUpdateState? State { get; set; }

        /// <summary>
        /// CodeQL query suite to be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_suite")]
        public global::G.CodeScanningDefaultSetupUpdateQuerySuite? QuerySuite { get; set; }

        /// <summary>
        /// CodeQL languages to be analyzed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages")]
        public global::System.Collections.Generic.IList<global::G.CodeScanningDefaultSetupUpdateLanguage>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodeScanningDefaultSetupUpdate? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningDefaultSetupUpdate>(
                json,
                jsonSerializerOptions);
        }

    }
}
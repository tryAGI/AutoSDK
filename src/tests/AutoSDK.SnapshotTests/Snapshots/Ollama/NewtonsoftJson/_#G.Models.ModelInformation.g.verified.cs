//HintName: G.Models.ModelInformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about a model.
    /// </summary>
    public sealed partial class ModelInformation
    {
        /// <summary>
        /// The architecture of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("general.architecture")]
        public string? GeneralArchitecture { get; set; }

        /// <summary>
        /// The file type of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("general.file_type")]
        public int? GeneralFileType { get; set; }

        /// <summary>
        /// The number of parameters in the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("general.parameter_count")]
        public long? GeneralParameterCount { get; set; }

        /// <summary>
        /// The number of parameters in the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("general.quantization_version")]
        public int? GeneralQuantizationVersion { get; set; }

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
        public static global::G.ModelInformation? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ModelInformation>(
                json,
                jsonSerializerOptions);
        }

    }
}
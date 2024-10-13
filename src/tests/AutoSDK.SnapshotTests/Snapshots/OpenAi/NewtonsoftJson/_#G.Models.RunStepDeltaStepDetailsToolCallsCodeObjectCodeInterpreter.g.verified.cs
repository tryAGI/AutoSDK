//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The Code Interpreter tool call definition.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter
    {
        /// <summary>
        /// The input to the Code Interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public string? Input { get; set; }

        /// <summary>
        /// The outputs from the Code Interpreter tool call. Code Interpreter can output one or more items, including text (`logs`) or images (`image`). Each of these are represented by a different object type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>? Outputs { get; set; }

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
        public static global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter>(
                json,
                jsonSerializerOptions);
        }

    }
}
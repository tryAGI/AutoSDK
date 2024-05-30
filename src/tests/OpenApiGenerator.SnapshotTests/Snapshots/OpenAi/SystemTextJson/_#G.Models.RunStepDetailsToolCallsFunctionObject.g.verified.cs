//HintName: G.Models.RunStepDetailsToolCallsFunctionObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFunctionObject
    {
        /// <summary>
        /// The ID of the tool call object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of tool call. This is always going to be `function` for this type of tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RunStepDetailsToolCallsFunctionObjectType Type { get; set; }

        /// <summary>
        /// The definition of the function that was called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RunStepDetailsToolCallsFunctionObjectFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
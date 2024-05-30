//HintName: G.Models.RunStepDetailsToolCallsCodeOutputImageObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeOutputImageObject
    {
        /// <summary>
        /// Always `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RunStepDetailsToolCallsCodeOutputImageObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RunStepDetailsToolCallsCodeOutputImageObjectImage Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
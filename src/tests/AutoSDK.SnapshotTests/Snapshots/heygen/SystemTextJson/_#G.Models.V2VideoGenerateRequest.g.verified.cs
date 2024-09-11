//HintName: G.Models.V2VideoGenerateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public global::G.V2VideoGenerateRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_id")]
        public global::G.V2VideoGenerateRequestCallbackId? CallbackId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public global::G.V2VideoGenerateRequestDimension? Dimension { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public bool Test { get; set; }

        /// <summary>
        /// Example: My Title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_inputs")]
        public global::System.Collections.Generic.IList<global::G.V2VideoGenerateRequestVideoInput>? VideoInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
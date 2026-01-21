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
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public object? AspectRatio { get; set; }

        /// <summary>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_id")]
        public object? CallbackId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public global::G.V2VideoGenerateRequestDimension? Dimension { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Example: My Title
        /// </summary>
        /// <example>My Title</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Example: [{"character":{"avatar_id":"Kristin_public_3_20240108","avatar_style":"normal","type":"avatar"},"voice":{"input_text":"Welcome to the new era of video creation with HeyGen! Simply type your script to get started!","type":"text","voice_id":"2f72ee82b83d4b00af16c4771d611752"}}]
        /// </summary>
        /// <example>[{"character":{"avatar_id":"Kristin_public_3_20240108","avatar_style":"normal","type":"avatar"},"voice":{"input_text":"Welcome to the new era of video creation with HeyGen! Simply type your script to get started!","type":"text","voice_id":"2f72ee82b83d4b00af16c4771d611752"}}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_inputs")]
        public global::System.Collections.Generic.IList<global::G.V2VideoGenerateRequestVideoInput>? VideoInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequest" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="callbackId">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dimension"></param>
        /// <param name="test">
        /// Example: true
        /// </param>
        /// <param name="title">
        /// Example: My Title
        /// </param>
        /// <param name="videoInputs">
        /// Example: [{"character":{"avatar_id":"Kristin_public_3_20240108","avatar_style":"normal","type":"avatar"},"voice":{"input_text":"Welcome to the new era of video creation with HeyGen! Simply type your script to get started!","type":"text","voice_id":"2f72ee82b83d4b00af16c4771d611752"}}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2VideoGenerateRequest(
            object? aspectRatio,
            object? callbackId,
            global::G.V2VideoGenerateRequestDimension? dimension,
            bool? test,
            string? title,
            global::System.Collections.Generic.IList<global::G.V2VideoGenerateRequestVideoInput>? videoInputs)
        {
            this.AspectRatio = aspectRatio;
            this.CallbackId = callbackId;
            this.Dimension = dimension;
            this.Test = test;
            this.Title = title;
            this.VideoInputs = videoInputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequest" /> class.
        /// </summary>
        public V2VideoGenerateRequest()
        {
        }
    }
}
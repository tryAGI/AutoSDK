//HintName: G.Models.ImageGenToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An image generation request made by the model.
    /// </summary>
    public sealed partial class ImageGenToolCall
    {
        /// <summary>
        /// The type of the image generation call. Always `image_generation_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenToolCallTypeJsonConverter))]
        public global::G.ImageGenToolCallType Type { get; set; }

        /// <summary>
        /// The unique ID of the image generation call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the image generation call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageGenToolCallStatus Status { get; set; }

        /// <summary>
        /// The generated image encoded in base64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolCall" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the image generation call. Always `image_generation_call`.
        /// </param>
        /// <param name="id">
        /// The unique ID of the image generation call.
        /// </param>
        /// <param name="status">
        /// The status of the image generation call.
        /// </param>
        /// <param name="result">
        /// The generated image encoded in base64.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenToolCall(
            string id,
            global::G.ImageGenToolCallStatus status,
            string? result,
            global::G.ImageGenToolCallType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolCall" /> class.
        /// </summary>
        public ImageGenToolCall()
        {
        }
    }
}
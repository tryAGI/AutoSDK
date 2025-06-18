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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ImageGenToolCallType Type { get; set; }

        /// <summary>
        /// The unique ID of the image generation call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The status of the image generation call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageGenToolCallStatus Status { get; set; } = default!;

        /// <summary>
        /// The generated image encoded in base64.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Result { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
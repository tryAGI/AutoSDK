//HintName: G.Models.CreateVideoEffectsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoEffectsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EffectsInput Input { get; set; } = default!;

        /// <summary>
        /// Model to use for effects generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Duration of the output video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoEffectsRequest" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="modelName">
        /// Model to use for effects generation.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        public CreateVideoEffectsRequest(
            global::G.EffectsInput input,
            string? modelName,
            string? duration,
            string? callbackUrl)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ModelName = modelName;
            this.Duration = duration;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoEffectsRequest" /> class.
        /// </summary>
        public CreateVideoEffectsRequest()
        {
        }
    }
}
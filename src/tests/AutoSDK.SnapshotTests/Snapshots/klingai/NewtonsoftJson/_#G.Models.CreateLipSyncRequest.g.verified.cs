//HintName: G.Models.CreateLipSyncRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLipSyncRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LipSyncInput Input { get; set; } = default!;

        /// <summary>
        /// Model to use for lip-sync.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public string? ModelName { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateLipSyncRequest" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="modelName">
        /// Model to use for lip-sync.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        public CreateLipSyncRequest(
            global::G.LipSyncInput input,
            string? modelName,
            string? callbackUrl)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ModelName = modelName;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLipSyncRequest" /> class.
        /// </summary>
        public CreateLipSyncRequest()
        {
        }
    }
}
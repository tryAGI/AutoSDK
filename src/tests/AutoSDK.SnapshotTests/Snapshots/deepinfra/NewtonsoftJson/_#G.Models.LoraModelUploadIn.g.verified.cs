//HintName: G.Models.LoraModelUploadIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoraModelUploadIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hf_model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string HfModelName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hf_token")]
        public string? HfToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string LoraModelName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_model_name")]
        public string? BaseModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoraModelUploadIn" /> class.
        /// </summary>
        /// <param name="hfModelName"></param>
        /// <param name="hfToken"></param>
        /// <param name="loraModelName"></param>
        /// <param name="baseModelName"></param>
        public LoraModelUploadIn(
            string hfModelName,
            string loraModelName,
            string? hfToken,
            string? baseModelName)
        {
            this.HfModelName = hfModelName ?? throw new global::System.ArgumentNullException(nameof(hfModelName));
            this.LoraModelName = loraModelName ?? throw new global::System.ArgumentNullException(nameof(loraModelName));
            this.HfToken = hfToken;
            this.BaseModelName = baseModelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoraModelUploadIn" /> class.
        /// </summary>
        public LoraModelUploadIn()
        {
        }
    }
}
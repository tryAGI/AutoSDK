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
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HfModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_token")]
        public string? HfToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LoraModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model_name")]
        public string? BaseModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoraModelUploadIn" /> class.
        /// </summary>
        /// <param name="hfModelName"></param>
        /// <param name="hfToken"></param>
        /// <param name="loraModelName"></param>
        /// <param name="baseModelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
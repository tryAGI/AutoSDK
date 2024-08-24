//HintName: G.Models.CreateTextureGenerationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextureGenerationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("front_rotation_offset")]
        public int? FrontRotationOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelAssetId")]
        public string? ModelAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_direction")]
        public string? PreviewDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sd_version")]
        public string? SdVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
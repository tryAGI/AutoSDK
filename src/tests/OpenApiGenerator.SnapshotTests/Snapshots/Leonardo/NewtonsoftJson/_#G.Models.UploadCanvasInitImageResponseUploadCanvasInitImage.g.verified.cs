//HintName: G.Models.UploadCanvasInitImageResponseUploadCanvasInitImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadCanvasInitImageResponseUploadCanvasInitImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initImageId")]
        public string? InitImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initFields")]
        public string? InitFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initKey")]
        public string? InitKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initUrl")]
        public string? InitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskImageId")]
        public string? MaskImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskFields")]
        public string? MaskFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskKey")]
        public string? MaskKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskUrl")]
        public string? MaskUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
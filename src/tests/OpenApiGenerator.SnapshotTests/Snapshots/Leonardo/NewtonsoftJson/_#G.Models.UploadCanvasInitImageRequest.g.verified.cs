//HintName: G.Models.UploadCanvasInitImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadCanvasInitImageRequest
    {
        /// <summary>
        /// Has to be png, jpg, jpeg, or webp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initExtension", Required = global::Newtonsoft.Json.Required.Always)]
        public string InitExtension { get; set; } = default!;

        /// <summary>
        /// Has to be png, jpg, jpeg, or webp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskExtension", Required = global::Newtonsoft.Json.Required.Always)]
        public string MaskExtension { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
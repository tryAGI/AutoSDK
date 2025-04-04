﻿//HintName: G.Models.UploadModelAssetResponseUploadModelAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadModelAssetResponseUploadModelAsset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelFields")]
        public string? ModelFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelKey")]
        public string? ModelKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelUrl")]
        public string? ModelUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelAssetResponseUploadModelAsset" /> class.
        /// </summary>
        /// <param name="modelFields"></param>
        /// <param name="modelId"></param>
        /// <param name="modelKey"></param>
        /// <param name="modelUrl"></param>
        public UploadModelAssetResponseUploadModelAsset(
            string? modelFields,
            string? modelId,
            string? modelKey,
            string? modelUrl)
        {
            this.ModelFields = modelFields;
            this.ModelId = modelId;
            this.ModelKey = modelKey;
            this.ModelUrl = modelUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelAssetResponseUploadModelAsset" /> class.
        /// </summary>
        public UploadModelAssetResponseUploadModelAsset()
        {
        }
    }
}
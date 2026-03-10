//HintName: G.Models.UpdateAssetParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssetParams
    {
        /// <summary>
        /// Default Value: update_asset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: update_asset
        /// </param>
        public UpdateAssetParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetParams" /> class.
        /// </summary>
        public UpdateAssetParams()
        {
        }
    }
}
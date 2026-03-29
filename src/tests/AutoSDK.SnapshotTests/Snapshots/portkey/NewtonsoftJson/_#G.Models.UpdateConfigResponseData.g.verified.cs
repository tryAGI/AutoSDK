//HintName: G.Models.UpdateConfigResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConfigResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id")]
        public global::System.Guid? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigResponseData" /> class.
        /// </summary>
        /// <param name="versionId"></param>
        public UpdateConfigResponseData(
            global::System.Guid? versionId)
        {
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigResponseData" /> class.
        /// </summary>
        public UpdateConfigResponseData()
        {
        }
    }
}
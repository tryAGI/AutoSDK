//HintName: G.Models.CreateConfigResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConfigResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateConfigResponseData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        public CreateConfigResponseData(
            global::System.Guid? id,
            global::System.Guid? versionId)
        {
            this.Id = id;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfigResponseData" /> class.
        /// </summary>
        public CreateConfigResponseData()
        {
        }
    }
}
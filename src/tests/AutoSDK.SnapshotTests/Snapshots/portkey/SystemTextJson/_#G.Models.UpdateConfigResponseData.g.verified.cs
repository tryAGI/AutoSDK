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
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public global::System.Guid? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigResponseData" /> class.
        /// </summary>
        /// <param name="versionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
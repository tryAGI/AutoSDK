//HintName: G.Models.RemovePronunciationDictionaryRulesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemovePronunciationDictionaryRulesResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemovePronunciationDictionaryRulesResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RemovePronunciationDictionaryRulesResponseModel(
            string id,
            string versionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemovePronunciationDictionaryRulesResponseModel" /> class.
        /// </summary>
        public RemovePronunciationDictionaryRulesResponseModel()
        {
        }
    }
}
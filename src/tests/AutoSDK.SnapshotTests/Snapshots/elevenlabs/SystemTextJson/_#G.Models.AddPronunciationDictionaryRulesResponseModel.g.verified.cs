//HintName: G.Models.AddPronunciationDictionaryRulesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddPronunciationDictionaryRulesResponseModel
    {
        /// <summary>
        /// The ID of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The version ID of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// The number of rules in the version of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_rules_num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionRulesNum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPronunciationDictionaryRulesResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the pronunciation dictionary.
        /// </param>
        /// <param name="versionId">
        /// The version ID of the pronunciation dictionary.
        /// </param>
        /// <param name="versionRulesNum">
        /// The number of rules in the version of the pronunciation dictionary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddPronunciationDictionaryRulesResponseModel(
            string id,
            string versionId,
            int versionRulesNum)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.VersionRulesNum = versionRulesNum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPronunciationDictionaryRulesResponseModel" /> class.
        /// </summary>
        public AddPronunciationDictionaryRulesResponseModel()
        {
        }
    }
}
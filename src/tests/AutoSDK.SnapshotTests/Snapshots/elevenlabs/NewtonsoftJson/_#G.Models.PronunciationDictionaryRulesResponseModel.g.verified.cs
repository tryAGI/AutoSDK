//HintName: G.Models.PronunciationDictionaryRulesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"id":"5xM3yVvZQKV0EfqQpLrJ","version_id":"5xM3yVvZQKV0EfqQpLr2"}
    /// </summary>
    public sealed partial class PronunciationDictionaryRulesResponseModel
    {
        /// <summary>
        /// The ID of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The version ID of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// The number of rules in the version of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_rules_num", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionRulesNum { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryRulesResponseModel" /> class.
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
        public PronunciationDictionaryRulesResponseModel(
            string id,
            string versionId,
            int versionRulesNum)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.VersionRulesNum = versionRulesNum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryRulesResponseModel" /> class.
        /// </summary>
        public PronunciationDictionaryRulesResponseModel()
        {
        }
    }
}
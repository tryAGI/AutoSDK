//HintName: G.Models.RepositoryRuleRequiredSignatures.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commits pushed to matching refs must have verified signatures.
    /// </summary>
    public sealed partial class RepositoryRuleRequiredSignatures
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleRequiredSignaturesTypeJsonConverter))]
        public global::G.RepositoryRuleRequiredSignaturesType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredSignatures" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleRequiredSignatures(
            global::G.RepositoryRuleRequiredSignaturesType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredSignatures" /> class.
        /// </summary>
        public RepositoryRuleRequiredSignatures()
        {
        }
    }
}
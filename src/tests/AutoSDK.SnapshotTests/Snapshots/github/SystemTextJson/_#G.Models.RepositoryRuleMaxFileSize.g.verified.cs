//HintName: G.Models.RepositoryRuleMaxFileSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prevent commits that exceed a specified file size limit from being pushed to the commit.
    /// </summary>
    public sealed partial class RepositoryRuleMaxFileSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleMaxFileSizeTypeJsonConverter))]
        public global::G.RepositoryRuleMaxFileSizeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.RepositoryRuleMaxFileSizeParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMaxFileSize" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleMaxFileSize(
            global::G.RepositoryRuleMaxFileSizeType type,
            global::G.RepositoryRuleMaxFileSizeParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMaxFileSize" /> class.
        /// </summary>
        public RepositoryRuleMaxFileSize()
        {
        }
    }
}
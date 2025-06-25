//HintName: G.Models.RepositoryRuleNonFastForward.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prevent users with push access from force pushing to refs.
    /// </summary>
    public sealed partial class RepositoryRuleNonFastForward
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleNonFastForwardTypeJsonConverter))]
        public global::G.RepositoryRuleNonFastForwardType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleNonFastForward" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleNonFastForward(
            global::G.RepositoryRuleNonFastForwardType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleNonFastForward" /> class.
        /// </summary>
        public RepositoryRuleNonFastForward()
        {
        }
    }
}
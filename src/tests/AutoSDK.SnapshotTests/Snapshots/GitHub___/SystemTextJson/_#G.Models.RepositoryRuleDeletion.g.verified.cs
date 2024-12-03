//HintName: G.Models.RepositoryRuleDeletion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Only allow users with bypass permissions to delete matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleDeletion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleDeletionTypeJsonConverter))]
        public global::G.RepositoryRuleDeletionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleDeletion" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRuleDeletion(
            global::G.RepositoryRuleDeletionType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleDeletion" /> class.
        /// </summary>
        public RepositoryRuleDeletion()
        {
        }
    }
}
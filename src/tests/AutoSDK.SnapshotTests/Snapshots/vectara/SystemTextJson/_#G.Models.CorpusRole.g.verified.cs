//HintName: G.Models.CorpusRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Corpus-specific role assignment.
    /// </summary>
    public sealed partial class CorpusRole
    {
        /// <summary>
        /// The key of the corpus this role applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CorpusKey { get; set; }

        /// <summary>
        /// The role assigned for this specific corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CorpusRoleRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CorpusRoleRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusRole" /> class.
        /// </summary>
        /// <param name="corpusKey">
        /// The key of the corpus this role applies to.
        /// </param>
        /// <param name="role">
        /// The role assigned for this specific corpus.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorpusRole(
            string corpusKey,
            global::G.CorpusRoleRole role)
        {
            this.CorpusKey = corpusKey ?? throw new global::System.ArgumentNullException(nameof(corpusKey));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusRole" /> class.
        /// </summary>
        public CorpusRole()
        {
        }
    }
}
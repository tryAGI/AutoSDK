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
        [global::Newtonsoft.Json.JsonProperty("corpus_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string CorpusKey { get; set; } = default!;

        /// <summary>
        /// The role assigned for this specific corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CorpusRoleRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
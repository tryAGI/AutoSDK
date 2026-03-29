//HintName: G.Models.SubstitutionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubstitutionConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("substitutionPhrase")]
        public string? SubstitutionPhrase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubstitutionConfig" /> class.
        /// </summary>
        /// <param name="substitutionPhrase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubstitutionConfig(
            string? substitutionPhrase)
        {
            this.SubstitutionPhrase = substitutionPhrase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubstitutionConfig" /> class.
        /// </summary>
        public SubstitutionConfig()
        {
        }
    }
}
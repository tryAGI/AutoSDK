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
        [global::Newtonsoft.Json.JsonProperty("substitutionPhrase")]
        public string? SubstitutionPhrase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubstitutionConfig" /> class.
        /// </summary>
        /// <param name="substitutionPhrase"></param>
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
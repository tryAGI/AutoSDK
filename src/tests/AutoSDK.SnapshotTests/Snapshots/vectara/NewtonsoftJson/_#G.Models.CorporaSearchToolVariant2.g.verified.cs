//HintName: G.Models.CorporaSearchToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorporaSearchToolVariant2
    {
        /// <summary>
        /// This should always be `corpora_search`.<br/>
        /// Default Value: corpora_search<br/>
        /// Example: corpora_search
        /// </summary>
        /// <default>"corpora_search"</default>
        /// <example>corpora_search</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorporaSearchToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `corpora_search`.<br/>
        /// Default Value: corpora_search<br/>
        /// Example: corpora_search
        /// </param>
        public CorporaSearchToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorporaSearchToolVariant2" /> class.
        /// </summary>
        public CorporaSearchToolVariant2()
        {
        }
    }
}
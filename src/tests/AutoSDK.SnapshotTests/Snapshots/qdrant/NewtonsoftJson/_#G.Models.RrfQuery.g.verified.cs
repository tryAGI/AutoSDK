//HintName: G.Models.RrfQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RrfQuery
    {
        /// <summary>
        /// Parameters for Reciprocal Rank Fusion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rrf", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Rrf Rrf { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RrfQuery" /> class.
        /// </summary>
        /// <param name="rrf">
        /// Parameters for Reciprocal Rank Fusion
        /// </param>
        public RrfQuery(
            global::G.Rrf rrf)
        {
            this.Rrf = rrf ?? throw new global::System.ArgumentNullException(nameof(rrf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RrfQuery" /> class.
        /// </summary>
        public RrfQuery()
        {
        }
    }
}
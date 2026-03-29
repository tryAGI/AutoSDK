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
        [global::System.Text.Json.Serialization.JsonPropertyName("rrf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Rrf Rrf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RrfQuery" /> class.
        /// </summary>
        /// <param name="rrf">
        /// Parameters for Reciprocal Rank Fusion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
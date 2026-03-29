//HintName: G.Models.Limit2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Limits the documents returned by a query.
    /// </summary>
    public sealed partial class Limit2
    {
        /// <summary>
        /// Limits the total number of documents returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Limits the number of documents with the same value for a set of attributes (the "limit key") that can appear in the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per")]
        public global::G.LimitPer? Per { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Limit2" /> class.
        /// </summary>
        /// <param name="total">
        /// Limits the total number of documents returned.
        /// </param>
        /// <param name="per">
        /// Limits the number of documents with the same value for a set of attributes (the "limit key") that can appear in the results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Limit2(
            int total,
            global::G.LimitPer? per)
        {
            this.Total = total;
            this.Per = per;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Limit2" /> class.
        /// </summary>
        public Limit2()
        {
        }
    }
}
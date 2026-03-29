//HintName: G.Models.LimitPer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Limits the number of documents with the same value for a set of attributes (the "limit key") that can appear in the results.
    /// </summary>
    public sealed partial class LimitPer
    {
        /// <summary>
        /// The attributes to include in the limit key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Attributes { get; set; } = default!;

        /// <summary>
        /// The maximum number of documents to return for each value of the limit key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitPer" /> class.
        /// </summary>
        /// <param name="attributes">
        /// The attributes to include in the limit key.
        /// </param>
        /// <param name="limit">
        /// The maximum number of documents to return for each value of the limit key.
        /// </param>
        public LimitPer(
            global::System.Collections.Generic.IList<string> attributes,
            int limit)
        {
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitPer" /> class.
        /// </summary>
        public LimitPer()
        {
        }
    }
}
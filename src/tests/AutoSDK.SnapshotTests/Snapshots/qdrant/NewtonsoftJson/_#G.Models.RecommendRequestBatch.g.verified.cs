//HintName: G.Models.RecommendRequestBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendRequestBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searches", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RecommendRequest> Searches { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendRequestBatch" /> class.
        /// </summary>
        /// <param name="searches"></param>
        public RecommendRequestBatch(
            global::System.Collections.Generic.IList<global::G.RecommendRequest> searches)
        {
            this.Searches = searches ?? throw new global::System.ArgumentNullException(nameof(searches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendRequestBatch" /> class.
        /// </summary>
        public RecommendRequestBatch()
        {
        }
    }
}
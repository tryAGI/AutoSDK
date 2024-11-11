//HintName: G.Models.ListCommitsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCommitsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CommitWithLookups> Commits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCommitsResponse" /> class.
        /// </summary>
        /// <param name="commits"></param>
        /// <param name="total"></param>
        public ListCommitsResponse(
            global::System.Collections.Generic.IList<global::G.CommitWithLookups> commits,
            int total)
        {
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCommitsResponse" /> class.
        /// </summary>
        public ListCommitsResponse()
        {
        }
    }
}
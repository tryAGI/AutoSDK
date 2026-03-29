//HintName: G.Models.SearchMotionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchMotionsRequest
    {
        /// <summary>
        /// Text prompt for motion search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Number of results to return
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_motions")]
        public int? NumMotions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMotionsRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// Text prompt for motion search
        /// </param>
        /// <param name="numMotions">
        /// Number of results to return
        /// </param>
        public SearchMotionsRequest(
            string? text,
            int? numMotions)
        {
            this.Text = text;
            this.NumMotions = numMotions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMotionsRequest" /> class.
        /// </summary>
        public SearchMotionsRequest()
        {
        }
    }
}
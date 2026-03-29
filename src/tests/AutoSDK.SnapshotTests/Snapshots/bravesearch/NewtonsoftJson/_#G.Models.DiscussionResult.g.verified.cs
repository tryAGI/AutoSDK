//HintName: G.Models.DiscussionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A forum/discussion result.
    /// </summary>
    public sealed partial class DiscussionResult
    {
        /// <summary>
        /// The type of the result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The discussion data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.DiscussionResultData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscussionResult" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the result.
        /// </param>
        /// <param name="data">
        /// The discussion data.
        /// </param>
        public DiscussionResult(
            string? type,
            global::G.DiscussionResultData? data)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscussionResult" /> class.
        /// </summary>
        public DiscussionResult()
        {
        }
    }
}
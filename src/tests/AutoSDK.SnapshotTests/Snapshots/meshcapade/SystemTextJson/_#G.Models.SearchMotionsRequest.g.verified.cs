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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Number of results to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_motions")]
        public int? NumMotions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
//HintName: G.Models.FeedbackRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Rating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackRequestRequest" /> class.
        /// </summary>
        /// <param name="rating"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackRequestRequest(
            bool rating)
        {
            this.Rating = rating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackRequestRequest" /> class.
        /// </summary>
        public FeedbackRequestRequest()
        {
        }
    }
}
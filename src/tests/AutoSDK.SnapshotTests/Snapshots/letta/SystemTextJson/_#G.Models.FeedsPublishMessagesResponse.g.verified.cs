//HintName: G.Models.FeedsPublishMessagesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsPublishMessagesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inserted_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InsertedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsPublishMessagesResponse" /> class.
        /// </summary>
        /// <param name="insertedCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedsPublishMessagesResponse(
            double insertedCount)
        {
            this.InsertedCount = insertedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsPublishMessagesResponse" /> class.
        /// </summary>
        public FeedsPublishMessagesResponse()
        {
        }
    }
}
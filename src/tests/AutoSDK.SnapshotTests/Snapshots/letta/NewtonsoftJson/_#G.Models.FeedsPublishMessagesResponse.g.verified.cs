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
        [global::Newtonsoft.Json.JsonProperty("inserted_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double InsertedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsPublishMessagesResponse" /> class.
        /// </summary>
        /// <param name="insertedCount"></param>
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
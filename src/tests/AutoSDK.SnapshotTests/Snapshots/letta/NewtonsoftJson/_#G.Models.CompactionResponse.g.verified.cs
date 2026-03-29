//HintName: G.Models.CompactionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompactionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_messages_before", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumMessagesBefore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_messages_after", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumMessagesAfter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionResponse" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="numMessagesBefore"></param>
        /// <param name="numMessagesAfter"></param>
        public CompactionResponse(
            string summary,
            int numMessagesBefore,
            int numMessagesAfter)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.NumMessagesBefore = numMessagesBefore;
            this.NumMessagesAfter = numMessagesAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionResponse" /> class.
        /// </summary>
        public CompactionResponse()
        {
        }
    }
}
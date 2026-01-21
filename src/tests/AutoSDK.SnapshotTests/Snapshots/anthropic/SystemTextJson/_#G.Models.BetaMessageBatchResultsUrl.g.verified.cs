//HintName: G.Models.BetaMessageBatchResultsUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// URL to a `.jsonl` file containing the results of the Message Batch requests. Specified only once processing ends.<br/>
    /// Results in the file are not guaranteed to be in the same order as requests. Use the `custom_id` field to match results to requests.
    /// </summary>
    public sealed partial class BetaMessageBatchResultsUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
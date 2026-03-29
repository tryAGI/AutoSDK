//HintName: G.Models.MessageSendErrors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Message send failures for a particular peer
    /// </summary>
    public sealed partial class MessageSendErrors
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_error")]
        public string? LatestError { get; set; }

        /// <summary>
        /// Timestamp of the latest error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_error_timestamp")]
        public global::System.DateTime? LatestErrorTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSendErrors" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="latestError"></param>
        /// <param name="latestErrorTimestamp">
        /// Timestamp of the latest error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageSendErrors(
            int count,
            string? latestError,
            global::System.DateTime? latestErrorTimestamp)
        {
            this.Count = count;
            this.LatestError = latestError;
            this.LatestErrorTimestamp = latestErrorTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSendErrors" /> class.
        /// </summary>
        public MessageSendErrors()
        {
        }
    }
}
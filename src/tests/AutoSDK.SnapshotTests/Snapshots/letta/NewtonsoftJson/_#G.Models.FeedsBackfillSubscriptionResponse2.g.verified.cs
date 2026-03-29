//HintName: G.Models.FeedsBackfillSubscriptionResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsBackfillSubscriptionResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorCode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FeedsBackfillSubscriptionResponseErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsBackfillSubscriptionResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        public FeedsBackfillSubscriptionResponse2(
            string message,
            global::G.FeedsBackfillSubscriptionResponseErrorCode errorCode)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsBackfillSubscriptionResponse2" /> class.
        /// </summary>
        public FeedsBackfillSubscriptionResponse2()
        {
        }
    }
}
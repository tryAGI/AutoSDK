//HintName: G.Models.CallBatchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallBatchResponse
    {
        /// <summary>
        /// Subscription limits at the end of this batch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptionLimits")]
        public global::G.SubscriptionLimits? SubscriptionLimits { get; set; }

        /// <summary>
        /// This is the list of calls that were created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Call> Results { get; set; } = default!;

        /// <summary>
        /// This is the list of calls that failed to be created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CallBatchError> Errors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// This is the list of calls that were created.
        /// </param>
        /// <param name="errors">
        /// This is the list of calls that failed to be created.
        /// </param>
        /// <param name="subscriptionLimits">
        /// Subscription limits at the end of this batch
        /// </param>
        public CallBatchResponse(
            global::System.Collections.Generic.IList<global::G.Call> results,
            global::System.Collections.Generic.IList<global::G.CallBatchError> errors,
            global::G.SubscriptionLimits? subscriptionLimits)
        {
            this.SubscriptionLimits = subscriptionLimits;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchResponse" /> class.
        /// </summary>
        public CallBatchResponse()
        {
        }
    }
}
//HintName: G.Models.CheckUserSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckUserSubscriptionResponse
    {
        /// <summary>
        /// A list that contains a single object with information about the user’s subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UserSubscription> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckUserSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains a single object with information about the user’s subscription.
        /// </param>
        public CheckUserSubscriptionResponse(
            global::System.Collections.Generic.IList<global::G.UserSubscription> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckUserSubscriptionResponse" /> class.
        /// </summary>
        public CheckUserSubscriptionResponse()
        {
        }
    }
}
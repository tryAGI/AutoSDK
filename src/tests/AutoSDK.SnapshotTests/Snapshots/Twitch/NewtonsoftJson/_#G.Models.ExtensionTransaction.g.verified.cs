//HintName: G.Models.ExtensionTransaction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtensionTransaction
    {
        /// <summary>
        /// An ID that identifies the transaction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of the transaction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// The ID of the broadcaster that owns the channel where the transaction occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The ID of the user that purchased the digital product.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The type of transaction. Possible values are:  <br/>
        ///   <br/>
        /// * BITS\_IN\_EXTENSION
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product_type")]
        public global::G.ExtensionTransactionProductType ProductType { get; set; }

        /// <summary>
        /// Contains details about the digital product.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product_data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionTransactionProductData ProductData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionTransaction" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies the transaction.
        /// </param>
        /// <param name="timestamp">
        /// The UTC date and time (in RFC3339 format) of the transaction.
        /// </param>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that owns the channel where the transaction occurred.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="userId">
        /// The ID of the user that purchased the digital product.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        /// <param name="productType">
        /// The type of transaction. Possible values are:  <br/>
        ///   <br/>
        /// * BITS\_IN\_EXTENSION
        /// </param>
        /// <param name="productData">
        /// Contains details about the digital product.
        /// </param>
        public ExtensionTransaction(
            string id,
            global::System.DateTime timestamp,
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string userId,
            string userLogin,
            string userName,
            global::G.ExtensionTransactionProductData productData,
            global::G.ExtensionTransactionProductType productType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Timestamp = timestamp;
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.ProductData = productData ?? throw new global::System.ArgumentNullException(nameof(productData));
            this.ProductType = productType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionTransaction" /> class.
        /// </summary>
        public ExtensionTransaction()
        {
        }
    }
}
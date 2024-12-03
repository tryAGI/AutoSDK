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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of the transaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// The ID of the broadcaster that owns the channel where the transaction occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The ID of the user that purchased the digital product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// The type of transaction. Possible values are:  <br/>
        ///   <br/>
        /// * BITS\_IN\_EXTENSION
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtensionTransactionProductTypeJsonConverter))]
        public global::G.ExtensionTransactionProductType ProductType { get; set; }

        /// <summary>
        /// Contains details about the digital product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionTransactionProductData ProductData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
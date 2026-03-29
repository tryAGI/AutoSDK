//HintName: G.Models.ShoppingResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single shopping search result.
    /// </summary>
    public sealed partial class ShoppingResult
    {
        /// <summary>
        /// Product title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Merchant/store name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// URL of the product page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Price of the product (formatted string, e.g., "$9.99").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public string? Price { get; set; }

        /// <summary>
        /// URL of the product image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Delivery information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        public string? Delivery { get; set; }

        /// <summary>
        /// Product rating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public double? Rating { get; set; }

        /// <summary>
        /// Number of product ratings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratingCount")]
        public int? RatingCount { get; set; }

        /// <summary>
        /// Special offers or pricing details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offers")]
        public string? Offers { get; set; }

        /// <summary>
        /// Google product ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        public string? ProductId { get; set; }

        /// <summary>
        /// Position of the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingResult" /> class.
        /// </summary>
        /// <param name="title">
        /// Product title.
        /// </param>
        /// <param name="source">
        /// Merchant/store name.
        /// </param>
        /// <param name="link">
        /// URL of the product page.
        /// </param>
        /// <param name="price">
        /// Price of the product (formatted string, e.g., "$9.99").
        /// </param>
        /// <param name="imageUrl">
        /// URL of the product image.
        /// </param>
        /// <param name="delivery">
        /// Delivery information.
        /// </param>
        /// <param name="rating">
        /// Product rating.
        /// </param>
        /// <param name="ratingCount">
        /// Number of product ratings.
        /// </param>
        /// <param name="offers">
        /// Special offers or pricing details.
        /// </param>
        /// <param name="productId">
        /// Google product ID.
        /// </param>
        /// <param name="position">
        /// Position of the result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShoppingResult(
            string? title,
            string? source,
            string? link,
            string? price,
            string? imageUrl,
            string? delivery,
            double? rating,
            int? ratingCount,
            string? offers,
            string? productId,
            int? position)
        {
            this.Title = title;
            this.Source = source;
            this.Link = link;
            this.Price = price;
            this.ImageUrl = imageUrl;
            this.Delivery = delivery;
            this.Rating = rating;
            this.RatingCount = ratingCount;
            this.Offers = offers;
            this.ProductId = productId;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingResult" /> class.
        /// </summary>
        public ShoppingResult()
        {
        }
    }
}
//HintName: G.Models.LocationResultReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocationResultReview
    {
        /// <summary>
        /// Review author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Review title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Review date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Review text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public global::G.LocationResultReviewRating? Rating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultReview" /> class.
        /// </summary>
        /// <param name="author">
        /// Review author.
        /// </param>
        /// <param name="title">
        /// Review title.
        /// </param>
        /// <param name="date">
        /// Review date.
        /// </param>
        /// <param name="description">
        /// Review text.
        /// </param>
        /// <param name="rating"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocationResultReview(
            string? author,
            string? title,
            string? date,
            string? description,
            global::G.LocationResultReviewRating? rating)
        {
            this.Author = author;
            this.Title = title;
            this.Date = date;
            this.Description = description;
            this.Rating = rating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultReview" /> class.
        /// </summary>
        public LocationResultReview()
        {
        }
    }
}
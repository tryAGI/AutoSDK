//HintName: G.Models.ChatCompletionContentPartImageWithTitleImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartImageWithTitleImageUrl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>))]
        public global::G.AnyOf<global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageWithTitleImageUrl" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="detail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartImageWithTitleImageUrl(
            string url,
            global::G.AnyOf<global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>? detail)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageWithTitleImageUrl" /> class.
        /// </summary>
        public ChatCompletionContentPartImageWithTitleImageUrl()
        {
        }
    }
}
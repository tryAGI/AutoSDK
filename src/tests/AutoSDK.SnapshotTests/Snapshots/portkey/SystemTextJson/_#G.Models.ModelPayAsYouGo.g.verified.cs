//HintName: G.Models.ModelPayAsYouGo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Token-based pricing (all prices in USD cents)
    /// </summary>
    public sealed partial class ModelPayAsYouGo
    {
        /// <summary>
        /// Price object (value is in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_token")]
        public global::G.ModelTokenPrice? RequestToken { get; set; }

        /// <summary>
        /// Price object (value is in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_token")]
        public global::G.ModelTokenPrice? ResponseToken { get; set; }

        /// <summary>
        /// Price object (value is in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_input_token")]
        public global::G.ModelTokenPrice? CacheWriteInputToken { get; set; }

        /// <summary>
        /// Price object (value is in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token")]
        public global::G.ModelTokenPrice? CacheReadInputToken { get; set; }

        /// <summary>
        /// Price object (value is in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_audio_token")]
        public global::G.ModelTokenPrice? RequestAudioToken { get; set; }

        /// <summary>
        /// Price object (value is in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_audio_token")]
        public global::G.ModelTokenPrice? ResponseAudioToken { get; set; }

        /// <summary>
        /// Price object (value is in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_audio_input_token")]
        public global::G.ModelTokenPrice? CacheReadAudioInputToken { get; set; }

        /// <summary>
        /// Provider-specific additional pricing units.<br/>
        /// Common additional units:<br/>
        /// - `web_search`: Web search tool usage<br/>
        /// - `file_search`: File search tool usage<br/>
        /// - `thinking_token`: Chain-of-thought reasoning tokens (Google)<br/>
        /// - `image_token`: Image generation tokens<br/>
        /// - `video_duration_seconds_*`: Video generation (OpenAI Sora)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_units")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ModelTokenPrice>? AdditionalUnits { get; set; }

        /// <summary>
        /// Image generation pricing by quality and size<br/>
        /// Example: {"standard":{"1024x1024":{"price":4},"1024x1792":{"price":8}},"hd":{"1024x1024":{"price":8},"1024x1792":{"price":12}}}
        /// </summary>
        /// <example>{"standard":{"1024x1024":{"price":4},"1024x1792":{"price":8}},"hd":{"1024x1024":{"price":8},"1024x1792":{"price":12}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.ModelTokenPrice>>? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPayAsYouGo" /> class.
        /// </summary>
        /// <param name="requestToken">
        /// Price object (value is in USD cents)
        /// </param>
        /// <param name="responseToken">
        /// Price object (value is in USD cents)
        /// </param>
        /// <param name="cacheWriteInputToken">
        /// Price object (value is in USD cents)
        /// </param>
        /// <param name="cacheReadInputToken">
        /// Price object (value is in USD cents)
        /// </param>
        /// <param name="requestAudioToken">
        /// Price object (value is in USD cents)
        /// </param>
        /// <param name="responseAudioToken">
        /// Price object (value is in USD cents)
        /// </param>
        /// <param name="cacheReadAudioInputToken">
        /// Price object (value is in USD cents)
        /// </param>
        /// <param name="additionalUnits">
        /// Provider-specific additional pricing units.<br/>
        /// Common additional units:<br/>
        /// - `web_search`: Web search tool usage<br/>
        /// - `file_search`: File search tool usage<br/>
        /// - `thinking_token`: Chain-of-thought reasoning tokens (Google)<br/>
        /// - `image_token`: Image generation tokens<br/>
        /// - `video_duration_seconds_*`: Video generation (OpenAI Sora)
        /// </param>
        /// <param name="image">
        /// Image generation pricing by quality and size<br/>
        /// Example: {"standard":{"1024x1024":{"price":4},"1024x1792":{"price":8}},"hd":{"1024x1024":{"price":8},"1024x1792":{"price":12}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPayAsYouGo(
            global::G.ModelTokenPrice? requestToken,
            global::G.ModelTokenPrice? responseToken,
            global::G.ModelTokenPrice? cacheWriteInputToken,
            global::G.ModelTokenPrice? cacheReadInputToken,
            global::G.ModelTokenPrice? requestAudioToken,
            global::G.ModelTokenPrice? responseAudioToken,
            global::G.ModelTokenPrice? cacheReadAudioInputToken,
            global::System.Collections.Generic.Dictionary<string, global::G.ModelTokenPrice>? additionalUnits,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.ModelTokenPrice>>? image)
        {
            this.RequestToken = requestToken;
            this.ResponseToken = responseToken;
            this.CacheWriteInputToken = cacheWriteInputToken;
            this.CacheReadInputToken = cacheReadInputToken;
            this.RequestAudioToken = requestAudioToken;
            this.ResponseAudioToken = responseAudioToken;
            this.CacheReadAudioInputToken = cacheReadAudioInputToken;
            this.AdditionalUnits = additionalUnits;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPayAsYouGo" /> class.
        /// </summary>
        public ModelPayAsYouGo()
        {
        }
    }
}
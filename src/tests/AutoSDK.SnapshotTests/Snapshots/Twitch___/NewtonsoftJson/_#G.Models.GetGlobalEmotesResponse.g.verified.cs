//HintName: G.Models.GetGlobalEmotesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGlobalEmotesResponse
    {
        /// <summary>
        /// The list of global emotes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GlobalEmote> Data { get; set; } = default!;

        /// <summary>
        /// A templated URL. Use the values from the `id`, `format`, `scale`, and `theme_mode` fields to replace the like-named placeholder strings in the templated URL to create a CDN (content delivery network) URL that you use to fetch the emote. For information about what the template looks like and how to use it to fetch emotes, see [Emote CDN URL format](https://dev.twitch.tv/docs/irc/emotes#cdn-template). You should use this template instead of using the URLs in the `images` object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template", Required = global::Newtonsoft.Json.Required.Always)]
        public string Template { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGlobalEmotesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of global emotes.
        /// </param>
        /// <param name="template">
        /// A templated URL. Use the values from the `id`, `format`, `scale`, and `theme_mode` fields to replace the like-named placeholder strings in the templated URL to create a CDN (content delivery network) URL that you use to fetch the emote. For information about what the template looks like and how to use it to fetch emotes, see [Emote CDN URL format](https://dev.twitch.tv/docs/irc/emotes#cdn-template). You should use this template instead of using the URLs in the `images` object.
        /// </param>
        public GetGlobalEmotesResponse(
            global::System.Collections.Generic.IList<global::G.GlobalEmote> data,
            string template)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGlobalEmotesResponse" /> class.
        /// </summary>
        public GetGlobalEmotesResponse()
        {
        }
    }
}
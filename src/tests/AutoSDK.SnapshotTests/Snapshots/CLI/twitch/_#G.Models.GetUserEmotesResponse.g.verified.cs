﻿//HintName: G.Models.GetUserEmotesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserEmotesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetUserEmotesResponseDataItem> Data { get; set; }

        /// <summary>
        /// A templated URL. Uses the values from the _id_, _format_, _scale_, and _theme\_mode_ fields to replace the like-named placeholder strings in the templated URL to create a CDN (content delivery network) URL that you use to fetch the emote.   <br/>
        ///   <br/>
        ///  For information about what the template looks like and how to use it to fetch emotes, see [Emote CDN URL](https://dev.twitch.tv/docs/irc/emotes#cdn-template) format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Template { get; set; }

        /// <summary>
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.   <br/>
        ///   <br/>
        ///  For more information about pagination support, see [Twitch API Guide - Pagination](https://dev.twitch.tv/docs/api/guide#pagination).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.GetUserEmotesResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserEmotesResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="template">
        /// A templated URL. Uses the values from the _id_, _format_, _scale_, and _theme\_mode_ fields to replace the like-named placeholder strings in the templated URL to create a CDN (content delivery network) URL that you use to fetch the emote.   <br/>
        ///   <br/>
        ///  For information about what the template looks like and how to use it to fetch emotes, see [Emote CDN URL](https://dev.twitch.tv/docs/irc/emotes#cdn-template) format.
        /// </param>
        /// <param name="pagination">
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.   <br/>
        ///   <br/>
        ///  For more information about pagination support, see [Twitch API Guide - Pagination](https://dev.twitch.tv/docs/api/guide#pagination).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserEmotesResponse(
            global::System.Collections.Generic.IList<global::G.GetUserEmotesResponseDataItem> data,
            string template,
            global::G.GetUserEmotesResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserEmotesResponse" /> class.
        /// </summary>
        public GetUserEmotesResponse()
        {
        }
    }
}
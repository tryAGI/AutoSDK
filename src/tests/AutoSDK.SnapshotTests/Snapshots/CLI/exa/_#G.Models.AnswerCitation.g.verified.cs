//HintName: G.Models.AnswerCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerCitation
    {
        /// <summary>
        /// The temporary ID for the document.<br/>
        /// Example: https://www.theguardian.com/science/2024/dec/11/spacex-valued-at-350bn-as-company-agrees-to-buy-shares-from-employees
        /// </summary>
        /// <example>https://www.theguardian.com/science/2024/dec/11/spacex-valued-at-350bn-as-company-agrees-to-buy-shares-from-employees</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The URL of the search result.<br/>
        /// Example: https://www.theguardian.com/science/2024/dec/11/spacex-valued-at-350bn-as-company-agrees-to-buy-shares-from-employees
        /// </summary>
        /// <example>https://www.theguardian.com/science/2024/dec/11/spacex-valued-at-350bn-as-company-agrees-to-buy-shares-from-employees</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The title of the search result.<br/>
        /// Example: SpaceX valued at $350bn as company agrees to buy shares from ...
        /// </summary>
        /// <example>SpaceX valued at $350bn as company agrees to buy shares from ...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// If available, the author of the content.<br/>
        /// Example: Dan Milmon
        /// </summary>
        /// <example>Dan Milmon</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// An estimate of the creation date, from parsing HTML content. Format is YYYY-MM-DD.<br/>
        /// Example: 2023-11-16T01:36:32.547Z
        /// </summary>
        /// <example>2023-11-16T01:36:32.547Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedDate")]
        public string? PublishedDate { get; set; }

        /// <summary>
        /// The full text content of each source. Only present when includeText is enabled.<br/>
        /// Example: SpaceX valued at $350bn as company agrees to buy shares from ...
        /// </summary>
        /// <example>SpaceX valued at $350bn as company agrees to buy shares from ...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The URL of the image associated with the search result, if available.<br/>
        /// Example: https://i.guim.co.uk/img/media/7cfee7e84b24b73c97a079c402642a333ad31e77/0_380_6176_3706/master/6176.jpg?width=1200&amp;height=630&amp;quality=85&amp;auto=format&amp;fit=crop&amp;overlay-align=bottom%2Cleft&amp;overlay-width=100p&amp;overlay-base64=L2ltZy9zdGF0aWMvb3ZlcmxheXMvdGctZGVmYXVsdC5wbmc&amp;enable=upscale&amp;s=71ebb2fbf458c185229d02d380c01530
        /// </summary>
        /// <example>https://i.guim.co.uk/img/media/7cfee7e84b24b73c97a079c402642a333ad31e77/0_380_6176_3706/master/6176.jpg?width=1200&amp;height=630&amp;quality=85&amp;auto=format&amp;fit=crop&amp;overlay-align=bottom%2Cleft&amp;overlay-width=100p&amp;overlay-base64=L2ltZy9zdGF0aWMvb3ZlcmxheXMvdGctZGVmYXVsdC5wbmc&amp;enable=upscale&amp;s=71ebb2fbf458c185229d02d380c01530</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// The URL of the favicon for the search result's domain, if available.<br/>
        /// Example: https://assets.guim.co.uk/static/frontend/icons/homescreen/apple-touch-icon.svg
        /// </summary>
        /// <example>https://assets.guim.co.uk/static/frontend/icons/homescreen/apple-touch-icon.svg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerCitation" /> class.
        /// </summary>
        /// <param name="id">
        /// The temporary ID for the document.<br/>
        /// Example: https://www.theguardian.com/science/2024/dec/11/spacex-valued-at-350bn-as-company-agrees-to-buy-shares-from-employees
        /// </param>
        /// <param name="url">
        /// The URL of the search result.<br/>
        /// Example: https://www.theguardian.com/science/2024/dec/11/spacex-valued-at-350bn-as-company-agrees-to-buy-shares-from-employees
        /// </param>
        /// <param name="title">
        /// The title of the search result.<br/>
        /// Example: SpaceX valued at $350bn as company agrees to buy shares from ...
        /// </param>
        /// <param name="author">
        /// If available, the author of the content.<br/>
        /// Example: Dan Milmon
        /// </param>
        /// <param name="publishedDate">
        /// An estimate of the creation date, from parsing HTML content. Format is YYYY-MM-DD.<br/>
        /// Example: 2023-11-16T01:36:32.547Z
        /// </param>
        /// <param name="text">
        /// The full text content of each source. Only present when includeText is enabled.<br/>
        /// Example: SpaceX valued at $350bn as company agrees to buy shares from ...
        /// </param>
        /// <param name="image">
        /// The URL of the image associated with the search result, if available.<br/>
        /// Example: https://i.guim.co.uk/img/media/7cfee7e84b24b73c97a079c402642a333ad31e77/0_380_6176_3706/master/6176.jpg?width=1200&amp;height=630&amp;quality=85&amp;auto=format&amp;fit=crop&amp;overlay-align=bottom%2Cleft&amp;overlay-width=100p&amp;overlay-base64=L2ltZy9zdGF0aWMvb3ZlcmxheXMvdGctZGVmYXVsdC5wbmc&amp;enable=upscale&amp;s=71ebb2fbf458c185229d02d380c01530
        /// </param>
        /// <param name="favicon">
        /// The URL of the favicon for the search result's domain, if available.<br/>
        /// Example: https://assets.guim.co.uk/static/frontend/icons/homescreen/apple-touch-icon.svg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerCitation(
            string? id,
            string? url,
            string? title,
            string? author,
            string? publishedDate,
            string? text,
            string? image,
            string? favicon)
        {
            this.Id = id;
            this.Url = url;
            this.Title = title;
            this.Author = author;
            this.PublishedDate = publishedDate;
            this.Text = text;
            this.Image = image;
            this.Favicon = favicon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerCitation" /> class.
        /// </summary>
        public AnswerCitation()
        {
        }
    }
}
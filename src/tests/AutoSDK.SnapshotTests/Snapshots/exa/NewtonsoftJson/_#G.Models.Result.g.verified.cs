//HintName: G.Models.Result.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Result
    {
        /// <summary>
        /// The title of the search result.<br/>
        /// Example: A Comprehensive Overview of Large Language Models
        /// </summary>
        /// <example>A Comprehensive Overview of Large Language Models</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The URL of the search result.<br/>
        /// Example: https://arxiv.org/pdf/2307.06435.pdf
        /// </summary>
        /// <example>https://arxiv.org/pdf/2307.06435.pdf</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// An estimate of the creation date, from parsing HTML content. Format is YYYY-MM-DD.<br/>
        /// Example: 2023-11-16T01:36:32.547Z
        /// </summary>
        /// <example>2023-11-16T01:36:32.547Z</example>
        [global::Newtonsoft.Json.JsonProperty("publishedDate")]
        public string? PublishedDate { get; set; }

        /// <summary>
        /// If available, the author of the content.<br/>
        /// Example: Humza  Naveed, University of Engineering and Technology (UET), Lahore, Pakistan
        /// </summary>
        /// <example>Humza  Naveed, University of Engineering and Technology (UET), Lahore, Pakistan</example>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>
        /// A number from 0 to 1 representing similarity between the query/url and the result.<br/>
        /// Example: 0.4600165784358978
        /// </summary>
        /// <example>0.4600165784358978</example>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The temporary ID for the document. Useful for /contents endpoint.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </summary>
        /// <example>https://arxiv.org/abs/2307.06435</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The URL of an image associated with the search result, if available.<br/>
        /// Example: https://arxiv.org/pdf/2307.06435.pdf/page_1.png
        /// </summary>
        /// <example>https://arxiv.org/pdf/2307.06435.pdf/page_1.png</example>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public string? Image { get; set; }

        /// <summary>
        /// The URL of the favicon for the search result's domain.<br/>
        /// Example: https://arxiv.org/favicon.ico
        /// </summary>
        /// <example>https://arxiv.org/favicon.ico</example>
        [global::Newtonsoft.Json.JsonProperty("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Result" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the search result.<br/>
        /// Example: A Comprehensive Overview of Large Language Models
        /// </param>
        /// <param name="url">
        /// The URL of the search result.<br/>
        /// Example: https://arxiv.org/pdf/2307.06435.pdf
        /// </param>
        /// <param name="publishedDate">
        /// An estimate of the creation date, from parsing HTML content. Format is YYYY-MM-DD.<br/>
        /// Example: 2023-11-16T01:36:32.547Z
        /// </param>
        /// <param name="author">
        /// If available, the author of the content.<br/>
        /// Example: Humza  Naveed, University of Engineering and Technology (UET), Lahore, Pakistan
        /// </param>
        /// <param name="score">
        /// A number from 0 to 1 representing similarity between the query/url and the result.<br/>
        /// Example: 0.4600165784358978
        /// </param>
        /// <param name="id">
        /// The temporary ID for the document. Useful for /contents endpoint.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </param>
        /// <param name="image">
        /// The URL of an image associated with the search result, if available.<br/>
        /// Example: https://arxiv.org/pdf/2307.06435.pdf/page_1.png
        /// </param>
        /// <param name="favicon">
        /// The URL of the favicon for the search result's domain.<br/>
        /// Example: https://arxiv.org/favicon.ico
        /// </param>
        public Result(
            string? title,
            string? url,
            string? publishedDate,
            string? author,
            double? score,
            string? id,
            string? image,
            string? favicon)
        {
            this.Title = title;
            this.Url = url;
            this.PublishedDate = publishedDate;
            this.Author = author;
            this.Score = score;
            this.Id = id;
            this.Image = image;
            this.Favicon = favicon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Result" /> class.
        /// </summary>
        public Result()
        {
        }
    }
}
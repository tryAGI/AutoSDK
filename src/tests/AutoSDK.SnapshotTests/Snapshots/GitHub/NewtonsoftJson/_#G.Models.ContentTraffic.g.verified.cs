//HintName: G.Models.ContentTraffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Content Traffic
    /// </summary>
    public sealed partial class ContentTraffic
    {
        /// <summary>
        /// Example: /github/hubot
        /// </summary>
        /// <example>/github/hubot</example>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Example: github/hubot: A customizable life embetterment robot.
        /// </summary>
        /// <example>github/hubot: A customizable life embetterment robot.</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Example: 3542
        /// </summary>
        /// <example>3542</example>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Example: 2225
        /// </summary>
        /// <example>2225</example>
        [global::Newtonsoft.Json.JsonProperty("uniques", Required = global::Newtonsoft.Json.Required.Always)]
        public int Uniques { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTraffic" /> class.
        /// </summary>
        /// <param name="path">
        /// Example: /github/hubot
        /// </param>
        /// <param name="title">
        /// Example: github/hubot: A customizable life embetterment robot.
        /// </param>
        /// <param name="count">
        /// Example: 3542
        /// </param>
        /// <param name="uniques">
        /// Example: 2225
        /// </param>
        public ContentTraffic(
            string path,
            string title,
            int count,
            int uniques)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Count = count;
            this.Uniques = uniques;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTraffic" /> class.
        /// </summary>
        public ContentTraffic()
        {
        }
    }
}
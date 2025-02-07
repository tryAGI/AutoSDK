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
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Example: github/hubot: A customizable life embetterment robot.
        /// </summary>
        /// <example>github/hubot: A customizable life embetterment robot.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Example: 3542
        /// </summary>
        /// <example>3542</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Example: 2225
        /// </summary>
        /// <example>2225</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniques")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Uniques { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
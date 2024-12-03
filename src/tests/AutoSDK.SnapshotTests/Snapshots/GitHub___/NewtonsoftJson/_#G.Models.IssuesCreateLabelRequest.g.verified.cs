//HintName: G.Models.IssuesCreateLabelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesCreateLabelRequest
    {
        /// <summary>
        /// The name of the label. Emoji can be added to label names, using either native emoji or colon-style markup. For example, typing `:strawberry:` will render the emoji ![:strawberry:](https://github.githubassets.com/images/icons/emoji/unicode/1f353.png ":strawberry:"). For a full list of available emoji and codes, see "[Emoji cheat sheet](https://github.com/ikatyang/emoji-cheat-sheet)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The [hexadecimal color code](http://www.color-hex.com/) for the label, without the leading `#`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// A short description of the label. Must be 100 characters or fewer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesCreateLabelRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the label. Emoji can be added to label names, using either native emoji or colon-style markup. For example, typing `:strawberry:` will render the emoji ![:strawberry:](https://github.githubassets.com/images/icons/emoji/unicode/1f353.png ":strawberry:"). For a full list of available emoji and codes, see "[Emoji cheat sheet](https://github.com/ikatyang/emoji-cheat-sheet)."
        /// </param>
        /// <param name="color">
        /// The [hexadecimal color code](http://www.color-hex.com/) for the label, without the leading `#`.
        /// </param>
        /// <param name="description">
        /// A short description of the label. Must be 100 characters or fewer.
        /// </param>
        public IssuesCreateLabelRequest(
            string name,
            string? color,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesCreateLabelRequest" /> class.
        /// </summary>
        public IssuesCreateLabelRequest()
        {
        }
    }
}
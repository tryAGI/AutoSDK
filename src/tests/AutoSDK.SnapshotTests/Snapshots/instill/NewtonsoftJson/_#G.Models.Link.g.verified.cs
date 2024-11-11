//HintName: G.Models.Link.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Link contains the information to display an reference to an external URL.
    /// </summary>
    public sealed partial class Link
    {
        /// <summary>
        /// Text contains the message to display.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// URL contains the reference the link will redirect to.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Link" /> class.
        /// </summary>
        /// <param name="text">
        /// Text contains the message to display.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// URL contains the reference the link will redirect to.<br/>
        /// Included only in responses
        /// </param>
        public Link(
            string? text,
            string? url)
        {
            this.Text = text;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Link" /> class.
        /// </summary>
        public Link()
        {
        }
    }
}
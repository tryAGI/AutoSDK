//HintName: G.Models.PodcastTextSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastTextSource
    {
        /// <summary>
        /// The type of source to create.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PodcastTextSourceType Type { get; set; }

        /// <summary>
        /// The text to create the podcast from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastTextSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of source to create.
        /// </param>
        /// <param name="text">
        /// The text to create the podcast from.
        /// </param>
        public PodcastTextSource(
            string text,
            global::G.PodcastTextSourceType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastTextSource" /> class.
        /// </summary>
        public PodcastTextSource()
        {
        }
    }
}
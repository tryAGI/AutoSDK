//HintName: G.Models.AudioUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for audio URL validation.
    /// </summary>
    public sealed partial class AudioUrl
    {
        /// <summary>
        /// The audio URL. Can be either a URL or a Data URI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The audio URL. Can be either a URL or a Data URI.
        /// </param>
        public AudioUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUrl" /> class.
        /// </summary>
        public AudioUrl()
        {
        }
    }
}
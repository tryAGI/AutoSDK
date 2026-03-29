//HintName: G.Models.ChatContentVideoInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Video input object
    /// </summary>
    public sealed partial class ChatContentVideoInput
    {
        /// <summary>
        /// URL of the video (data: URLs supported)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentVideoInput" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the video (data: URLs supported)
        /// </param>
        public ChatContentVideoInput(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentVideoInput" /> class.
        /// </summary>
        public ChatContentVideoInput()
        {
        }
    }
}
//HintName: G.Models.DeleteClipResponseConfigLogo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteClipResponseConfigLogo
    {
        /// <summary>
        /// https url to an ARGB jpg/png image, a default logo is used otherwise
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// position of the logo in pixels from the top left corner (w,h) negative values are subtracted from last pixel<br/>
        /// Example: [0, 500]
        /// </summary>
        /// <example>[0, 500]</example>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Position { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteClipResponseConfigLogo" /> class.
        /// </summary>
        /// <param name="url">
        /// https url to an ARGB jpg/png image, a default logo is used otherwise
        /// </param>
        /// <param name="position">
        /// position of the logo in pixels from the top left corner (w,h) negative values are subtracted from last pixel<br/>
        /// Example: [0, 500]
        /// </param>
        public DeleteClipResponseConfigLogo(
            string url,
            global::System.Collections.Generic.IList<int> position)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteClipResponseConfigLogo" /> class.
        /// </summary>
        public DeleteClipResponseConfigLogo()
        {
        }
    }
}
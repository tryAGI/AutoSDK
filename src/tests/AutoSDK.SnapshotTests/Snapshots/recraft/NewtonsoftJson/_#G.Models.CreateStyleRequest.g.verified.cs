//HintName: G.Models.CreateStyleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStyleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Images { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageStyle Style { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRequest" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="style"></param>
        public CreateStyleRequest(
            global::System.Collections.Generic.IList<byte[]> images,
            global::G.ImageStyle style)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Style = style;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRequest" /> class.
        /// </summary>
        public CreateStyleRequest()
        {
        }
    }
}
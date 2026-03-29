//HintName: G.Models.EditImageGetLayersVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetLayersVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EditImageGetLayersVariant2Image Image { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant2" /> class.
        /// </summary>
        /// <param name="image"></param>
        public EditImageGetLayersVariant2(
            global::G.EditImageGetLayersVariant2Image image)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant2" /> class.
        /// </summary>
        public EditImageGetLayersVariant2()
        {
        }
    }
}
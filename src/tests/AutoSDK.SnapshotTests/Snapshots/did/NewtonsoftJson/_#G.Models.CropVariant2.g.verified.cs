//HintName: G.Models.CropVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom crop
    /// </summary>
    public sealed partial class CropVariant2
    {
        /// <summary>
        /// The type of the crop.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CropVariant2TypeJsonConverter))]
        public global::G.CropVariant2Type Type { get; set; }

        /// <summary>
        /// A set of numbers between 0 and 1 representing the top, left, right and bottom of the crop.<br/>
        /// Each number correlates to the distance from the top left corner of the image, relative the the image width.<br/>
        /// For example, right: 0.75 means that the right side of the crop is 75% of the image width from the left side.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rectangle", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CropVariant2Rectangle Rectangle { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CropVariant2" /> class.
        /// </summary>
        /// <param name="rectangle">
        /// A set of numbers between 0 and 1 representing the top, left, right and bottom of the crop.<br/>
        /// Each number correlates to the distance from the top left corner of the image, relative the the image width.<br/>
        /// For example, right: 0.75 means that the right side of the crop is 75% of the image width from the left side.
        /// </param>
        /// <param name="type">
        /// The type of the crop.
        /// </param>
        public CropVariant2(
            global::G.CropVariant2Rectangle rectangle,
            global::G.CropVariant2Type type)
        {
            this.Type = type;
            this.Rectangle = rectangle ?? throw new global::System.ArgumentNullException(nameof(rectangle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CropVariant2" /> class.
        /// </summary>
        public CropVariant2()
        {
        }
    }
}
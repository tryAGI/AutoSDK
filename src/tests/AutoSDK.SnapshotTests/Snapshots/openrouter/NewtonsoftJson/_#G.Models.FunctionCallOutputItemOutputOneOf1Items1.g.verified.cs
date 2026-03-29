//HintName: G.Models.FunctionCallOutputItemOutputOneOf1Items1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image input content item
    /// </summary>
    public sealed partial class FunctionCallOutputItemOutputOneOf1Items1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputImageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputImageDetail Detail { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItemOutputOneOf1Items1" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="type"></param>
        /// <param name="imageUrl"></param>
        public FunctionCallOutputItemOutputOneOf1Items1(
            global::G.InputImageDetail detail,
            global::G.InputImageType type,
            string? imageUrl)
        {
            this.Type = type;
            this.Detail = detail;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItemOutputOneOf1Items1" /> class.
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items1()
        {
        }
    }
}
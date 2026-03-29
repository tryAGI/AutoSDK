//HintName: G.Models.Size.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Size.
    /// </summary>
    public sealed partial class Size
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public double? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Size" /> class.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Size(
            double? width,
            double? height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Size" /> class.
        /// </summary>
        public Size()
        {
        }
    }
}
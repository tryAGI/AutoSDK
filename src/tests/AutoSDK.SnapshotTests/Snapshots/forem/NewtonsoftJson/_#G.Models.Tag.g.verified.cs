//HintName: G.Models.Tag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of a tag
    /// </summary>
    public sealed partial class Tag
    {
        /// <summary>
        /// Tag id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bg_color_hex")]
        public string? BgColorHex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_color_hex")]
        public string? TextColorHex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        /// <param name="id">
        /// Tag id
        /// </param>
        /// <param name="name"></param>
        /// <param name="bgColorHex"></param>
        /// <param name="textColorHex"></param>
        public Tag(
            long? id,
            string? name,
            string? bgColorHex,
            string? textColorHex)
        {
            this.Id = id;
            this.Name = name;
            this.BgColorHex = bgColorHex;
            this.TextColorHex = textColorHex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        public Tag()
        {
        }
    }
}
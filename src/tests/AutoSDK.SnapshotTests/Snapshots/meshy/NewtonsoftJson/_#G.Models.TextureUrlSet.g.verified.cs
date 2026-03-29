//HintName: G.Models.TextureUrlSet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextureUrlSet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_color")]
        public string? BaseColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metallic")]
        public string? Metallic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normal")]
        public string? Normal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roughness")]
        public string? Roughness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextureUrlSet" /> class.
        /// </summary>
        /// <param name="baseColor"></param>
        /// <param name="metallic"></param>
        /// <param name="normal"></param>
        /// <param name="roughness"></param>
        public TextureUrlSet(
            string? baseColor,
            string? metallic,
            string? normal,
            string? roughness)
        {
            this.BaseColor = baseColor;
            this.Metallic = metallic;
            this.Normal = normal;
            this.Roughness = roughness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextureUrlSet" /> class.
        /// </summary>
        public TextureUrlSet()
        {
        }
    }
}
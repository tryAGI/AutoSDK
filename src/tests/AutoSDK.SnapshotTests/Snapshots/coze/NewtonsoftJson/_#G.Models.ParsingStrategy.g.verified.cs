//HintName: G.Models.ParsingStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParsingStrategy
    {
        /// <summary>
        /// 是否开启图片元素提取（精准解析时生效）
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_extraction")]
        public bool? ImageExtraction { get; set; }

        /// <summary>
        /// 是否开启图片OCR（精准解析时生效）
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_ocr")]
        public bool? ImageOcr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsing_type")]
        public int? ParsingType { get; set; }

        /// <summary>
        /// 是否开启表格元素提取（精准解析时生效）
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table_extraction")]
        public bool? TableExtraction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingStrategy" /> class.
        /// </summary>
        /// <param name="imageExtraction">
        /// 是否开启图片元素提取（精准解析时生效）
        /// </param>
        /// <param name="imageOcr">
        /// 是否开启图片OCR（精准解析时生效）
        /// </param>
        /// <param name="parsingType"></param>
        /// <param name="tableExtraction">
        /// 是否开启表格元素提取（精准解析时生效）
        /// </param>
        public ParsingStrategy(
            bool? imageExtraction,
            bool? imageOcr,
            int? parsingType,
            bool? tableExtraction)
        {
            this.ImageExtraction = imageExtraction;
            this.ImageOcr = imageOcr;
            this.ParsingType = parsingType;
            this.TableExtraction = tableExtraction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingStrategy" /> class.
        /// </summary>
        public ParsingStrategy()
        {
        }
    }
}
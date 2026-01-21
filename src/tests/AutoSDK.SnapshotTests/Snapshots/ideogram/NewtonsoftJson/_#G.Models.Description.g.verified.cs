//HintName: G.Models.Description.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"text":"A meticulously illustrated cat with striped patterns, sitting upright. The cat\u0027s eyes are a captivating shade of yellow, and it appears to be gazing intently at something. The background consists of abstract, swirling patterns in shades of black, white, and beige, creating an almost fluid or wavy appearance. The cat is positioned in the foreground, with the background elements fading into the distance, giving a sense of depth to the image."}
    /// </summary>
    public sealed partial class Description
    {
        /// <summary>
        /// The generated description for the provided image.<br/>
        /// Example: A meticulously illustrated cat with striped patterns, sitting upright. The cat's eyes are a captivating shade of yellow, and it appears to be gazing intently at something. The background consists of abstract, swirling patterns in shades of black, white, and beige, creating an almost fluid or wavy appearance. The cat is positioned in the foreground, with the background elements fading into the distance, giving a sense of depth to the image.
        /// </summary>
        /// <example>A meticulously illustrated cat with striped patterns, sitting upright. The cat's eyes are a captivating shade of yellow, and it appears to be gazing intently at something. The background consists of abstract, swirling patterns in shades of black, white, and beige, creating an almost fluid or wavy appearance. The cat is positioned in the foreground, with the background elements fading into the distance, giving a sense of depth to the image.</example>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Description" /> class.
        /// </summary>
        /// <param name="text">
        /// The generated description for the provided image.<br/>
        /// Example: A meticulously illustrated cat with striped patterns, sitting upright. The cat's eyes are a captivating shade of yellow, and it appears to be gazing intently at something. The background consists of abstract, swirling patterns in shades of black, white, and beige, creating an almost fluid or wavy appearance. The cat is positioned in the foreground, with the background elements fading into the distance, giving a sense of depth to the image.
        /// </param>
        public Description(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Description" /> class.
        /// </summary>
        public Description()
        {
        }
    }
}
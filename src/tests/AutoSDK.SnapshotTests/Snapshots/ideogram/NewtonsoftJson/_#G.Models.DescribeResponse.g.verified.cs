//HintName: G.Models.DescribeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response for a describe request encapsulates a list of descriptions<br/>
    /// Example: {"descriptions":[{"text":"A meticulously illustrated cat with striped patterns, sitting upright. The cat\u0027s eyes are a captivating shade of yellow, and it appears to be gazing intently at something. The background consists of abstract, swirling patterns in shades of black, white, and beige, creating an almost fluid or wavy appearance. The cat is positioned in the foreground, with the background elements fading into the distance, giving a sense of depth to the image."},{"text":"A meticulously illustrated cat with striped patterns, sitting upright. The cat\u0027s eyes are a captivating shade of yellow, and it appears to be gazing intently at something. The background consists of abstract, swirling patterns in shades of black, white, and beige, creating an almost fluid or wavy appearance. The cat is positioned in the foreground, with the background elements fading into the distance, giving a sense of depth to the image."}]}
    /// </summary>
    public sealed partial class DescribeResponse
    {
        /// <summary>
        /// A collection of descriptions for given content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptions")]
        public global::System.Collections.Generic.IList<global::G.Description>? Descriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeResponse" /> class.
        /// </summary>
        /// <param name="descriptions">
        /// A collection of descriptions for given content
        /// </param>
        public DescribeResponse(
            global::System.Collections.Generic.IList<global::G.Description>? descriptions)
        {
            this.Descriptions = descriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeResponse" /> class.
        /// </summary>
        public DescribeResponse()
        {
        }
    }
}
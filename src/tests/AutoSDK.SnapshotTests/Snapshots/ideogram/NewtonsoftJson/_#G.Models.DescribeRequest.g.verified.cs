//HintName: G.Models.DescribeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
    /// </summary>
    public sealed partial class DescribeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] ImageFile { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageFilename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] ImageFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeRequest" /> class.
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeRequest(
            byte[] imageFile,
            string imageFilename)
        {
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.ImageFilename = imageFilename ?? throw new global::System.ArgumentNullException(nameof(imageFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeRequest" /> class.
        /// </summary>
        public DescribeRequest()
        {
        }
    }
}
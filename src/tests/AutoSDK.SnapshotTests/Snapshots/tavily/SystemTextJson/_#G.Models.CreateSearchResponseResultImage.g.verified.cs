//HintName: G.Models.CreateSearchResponseResultImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSearchResponseResultImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchResponseResultImage" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSearchResponseResultImage(
            string? url,
            string? description)
        {
            this.Url = url;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchResponseResultImage" /> class.
        /// </summary>
        public CreateSearchResponseResultImage()
        {
        }
    }
}
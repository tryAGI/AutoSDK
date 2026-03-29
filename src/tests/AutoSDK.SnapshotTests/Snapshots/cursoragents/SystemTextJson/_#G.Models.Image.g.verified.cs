//HintName: G.Models.Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// Base64 encoded image data<br/>
        /// Example: iVBORw0KGgoAAAANSUhEUgAA...
        /// </summary>
        /// <example>iVBORw0KGgoAAAANSUhEUgAA...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public global::G.ImageDimension? Dimension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64 encoded image data<br/>
        /// Example: iVBORw0KGgoAAAANSUhEUgAA...
        /// </param>
        /// <param name="dimension"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Image(
            string data,
            global::G.ImageDimension? dimension)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dimension = dimension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }
    }
}
//HintName: G.Models.V2VideoGenerateRequestDimension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequestDimension
    {
        /// <summary>
        /// Example: 720
        /// </summary>
        /// <example>720</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Example: 1280
        /// </summary>
        /// <example>1280</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestDimension" /> class.
        /// </summary>
        /// <param name="height">
        /// Example: 720
        /// </param>
        /// <param name="width">
        /// Example: 1280
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2VideoGenerateRequestDimension(
            double? height,
            double? width)
        {
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestDimension" /> class.
        /// </summary>
        public V2VideoGenerateRequestDimension()
        {
        }
    }
}
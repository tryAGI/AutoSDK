//HintName: G.Models.ImageReadToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageReadToolVariant2
    {
        /// <summary>
        /// This should always be `image_read`.<br/>
        /// Default Value: image_read<br/>
        /// Example: image_read
        /// </summary>
        /// <default>"image_read"</default>
        /// <example>image_read</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "image_read";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `image_read`.<br/>
        /// Default Value: image_read<br/>
        /// Example: image_read
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageReadToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadToolVariant2" /> class.
        /// </summary>
        public ImageReadToolVariant2()
        {
        }
    }
}
//HintName: recraft.Models.CreateStyleRequest.g.cs

#nullable enable

namespace recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStyleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::recraft.JsonConverters.ImageStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::recraft.ImageStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRequest" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="style"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStyleRequest(
            global::System.Collections.Generic.IList<byte[]> images,
            global::recraft.ImageStyle style)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Style = style;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRequest" /> class.
        /// </summary>
        public CreateStyleRequest()
        {
        }
    }
}
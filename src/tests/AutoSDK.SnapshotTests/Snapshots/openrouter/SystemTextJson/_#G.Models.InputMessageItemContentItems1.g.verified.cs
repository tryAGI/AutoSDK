//HintName: G.Models.InputMessageItemContentItems1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image input content item
    /// </summary>
    public sealed partial class InputMessageItemContentItems1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputImageTypeJsonConverter))]
        public global::G.InputImageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InputImageDetail Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageItemContentItems1" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="type"></param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputMessageItemContentItems1(
            global::G.InputImageDetail detail,
            global::G.InputImageType type,
            string? imageUrl)
        {
            this.Type = type;
            this.Detail = detail;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageItemContentItems1" /> class.
        /// </summary>
        public InputMessageItemContentItems1()
        {
        }
    }
}
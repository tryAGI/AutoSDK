//HintName: G.Models.ExtensionIconUrls.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary that contains URLs to different sizes of the default icon. The dictionary’s key identifies the icon’s size (for example, 24x24), and the dictionary’s value contains the URL to the icon.
    /// </summary>
    public sealed partial class ExtensionIconUrls
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("100x100")]
        public string? x100x100 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("24x24")]
        public string? x24x24 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("300x200")]
        public string? x300x200 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionIconUrls" /> class.
        /// </summary>
        /// <param name="x100x100"></param>
        /// <param name="x24x24"></param>
        /// <param name="x300x200"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtensionIconUrls(
            string? x100x100,
            string? x24x24,
            string? x300x200)
        {
            this.x100x100 = x100x100;
            this.x24x24 = x24x24;
            this.x300x200 = x300x200;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionIconUrls" /> class.
        /// </summary>
        public ExtensionIconUrls()
        {
        }
    }
}
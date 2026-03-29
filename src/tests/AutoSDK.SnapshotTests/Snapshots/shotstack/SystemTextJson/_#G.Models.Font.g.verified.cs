//HintName: G.Models.Font.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Download a custom font to use with the HTML asset type, using the font name in the CSS or font tag. See our [custom fonts](https://shotstack.io/learn/html-custom-fonts/) getting started guide for more details.
    /// </summary>
    public sealed partial class Font
    {
        /// <summary>
        /// The URL of the font file. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/open-sans.ttf
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/open-sans.ttf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Font" /> class.
        /// </summary>
        /// <param name="src">
        /// The URL of the font file. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/open-sans.ttf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Font(
            string src)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Font" /> class.
        /// </summary>
        public Font()
        {
        }
    }
}
//HintName: G.Models.TextAlignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Horizontal and vertical alignment properties for text.
    /// </summary>
    public sealed partial class TextAlignment
    {
        /// <summary>
        /// The horizontal alignment of the text. Value must be one of: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`left`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`center`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`right`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: center
        /// </summary>
        /// <example>center</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextAlignmentHorizontalJsonConverter))]
        public global::G.TextAlignmentHorizontal? Horizontal { get; set; }

        /// <summary>
        /// The vertical alignment of the text. Value must be one of: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`top`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`center`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottom`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: center
        /// </summary>
        /// <example>center</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextAlignmentVerticalJsonConverter))]
        public global::G.TextAlignmentVertical? Vertical { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAlignment" /> class.
        /// </summary>
        /// <param name="horizontal">
        /// The horizontal alignment of the text. Value must be one of: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`left`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`center`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`right`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: center
        /// </param>
        /// <param name="vertical">
        /// The vertical alignment of the text. Value must be one of: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`top`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`center`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottom`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: center
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextAlignment(
            global::G.TextAlignmentHorizontal? horizontal,
            global::G.TextAlignmentVertical? vertical)
        {
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAlignment" /> class.
        /// </summary>
        public TextAlignment()
        {
        }
    }
}
//HintName: G.Models.TextToImageRequestBodyVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToImageRequestBodyVariant1
    {
        /// <summary>
        /// Height of the image in pixels.  Must be in increments of 64 and pass the following validation:<br/>
        /// - For 768 engines: &lt;span style='display: flex; justify-content: flex-start; gap:8px'&gt;589,824 &lt;span&gt;≤&lt;/span&gt; `height * width` &lt;span&gt;≤&lt;/span&gt; 1,048,576&lt;/span&gt;<br/>
        /// - All other engines: &lt;span style='display: flex; justify-content: flex-start; gap:8px'&gt;262,144 &lt;span&gt;≤&lt;/span&gt; `height * width` &lt;span&gt;≤&lt;/span&gt; 1,048,576&lt;/span&gt;<br/>
        /// Default Value: 512<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width of the image in pixels.  Must be in increments of 64 and pass the following validation:<br/>
        /// - For 768 engines: &lt;span style='display: flex; justify-content: flex-start; gap:8px'&gt;589,824 &lt;span&gt;≤&lt;/span&gt; `height * width` &lt;span&gt;≤&lt;/span&gt; 1,048,576&lt;/span&gt;<br/>
        /// - All other engines: &lt;span style='display: flex; justify-content: flex-start; gap:8px'&gt;262,144 &lt;span&gt;≤&lt;/span&gt; `height * width` &lt;span&gt;≤&lt;/span&gt; 1,048,576&lt;/span&gt;<br/>
        /// Default Value: 512<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// An array of text prompts to use for generation.<br/>
        /// Given a text prompt with the text `A lighthouse on a cliff` and a weight of `0.5`, it would be represented as:<br/>
        /// &lt;pre&gt;<br/>
        /// "text_prompts": [<br/>
        ///   {<br/>
        ///     "text": "A lighthouse on a cliff",<br/>
        ///     "weight": 0.5<br/>
        ///   }<br/>
        /// ]<br/>
        /// &lt;/pre&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TextPrompt> TextPrompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageRequestBodyVariant1" /> class.
        /// </summary>
        /// <param name="textPrompts">
        /// An array of text prompts to use for generation.<br/>
        /// Given a text prompt with the text `A lighthouse on a cliff` and a weight of `0.5`, it would be represented as:<br/>
        /// &lt;pre&gt;<br/>
        /// "text_prompts": [<br/>
        ///   {<br/>
        ///     "text": "A lighthouse on a cliff",<br/>
        ///     "weight": 0.5<br/>
        ///   }<br/>
        /// ]<br/>
        /// &lt;/pre&gt;
        /// </param>
        /// <param name="height">
        /// Height of the image in pixels.  Must be in increments of 64 and pass the following validation:<br/>
        /// - For 768 engines: &lt;span style='display: flex; justify-content: flex-start; gap:8px'&gt;589,824 &lt;span&gt;≤&lt;/span&gt; `height * width` &lt;span&gt;≤&lt;/span&gt; 1,048,576&lt;/span&gt;<br/>
        /// - All other engines: &lt;span style='display: flex; justify-content: flex-start; gap:8px'&gt;262,144 &lt;span&gt;≤&lt;/span&gt; `height * width` &lt;span&gt;≤&lt;/span&gt; 1,048,576&lt;/span&gt;<br/>
        /// Default Value: 512<br/>
        /// Example: 512
        /// </param>
        /// <param name="width">
        /// Width of the image in pixels.  Must be in increments of 64 and pass the following validation:<br/>
        /// - For 768 engines: &lt;span style='display: flex; justify-content: flex-start; gap:8px'&gt;589,824 &lt;span&gt;≤&lt;/span&gt; `height * width` &lt;span&gt;≤&lt;/span&gt; 1,048,576&lt;/span&gt;<br/>
        /// - All other engines: &lt;span style='display: flex; justify-content: flex-start; gap:8px'&gt;262,144 &lt;span&gt;≤&lt;/span&gt; `height * width` &lt;span&gt;≤&lt;/span&gt; 1,048,576&lt;/span&gt;<br/>
        /// Default Value: 512<br/>
        /// Example: 512
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToImageRequestBodyVariant1(
            global::System.Collections.Generic.IList<global::G.TextPrompt> textPrompts,
            int? height,
            int? width)
        {
            this.Height = height;
            this.Width = width;
            this.TextPrompts = textPrompts ?? throw new global::System.ArgumentNullException(nameof(textPrompts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageRequestBodyVariant1" /> class.
        /// </summary>
        public TextToImageRequestBodyVariant1()
        {
        }
    }
}
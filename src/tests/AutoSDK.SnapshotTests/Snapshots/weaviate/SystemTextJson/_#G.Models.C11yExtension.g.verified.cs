//HintName: G.Models.C11yExtension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A resource describing an extension to the contextinoary, containing both the identifier and the definition of the extension
    /// </summary>
    public sealed partial class C11yExtension
    {
        /// <summary>
        /// The new concept you want to extend. Must be an all-lowercase single word, or a space delimited compound word. Examples: 'foobarium', 'my custom concept'<br/>
        /// Example: foobarium
        /// </summary>
        /// <example>foobarium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("concept")]
        public string? Concept { get; set; }

        /// <summary>
        /// A list of space-delimited words or a sentence describing what the custom concept is about. Avoid using the custom concept itself. An Example definition for the custom concept 'foobarium': would be 'a naturally occurring element which can only be seen by programmers'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        public string? Definition { get; set; }

        /// <summary>
        /// Weight of the definition of the new concept where 1='override existing definition entirely' and 0='ignore custom definition'. Note that if the custom concept is not present in the contextionary yet, the weight cannot be less than 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yExtension" /> class.
        /// </summary>
        /// <param name="concept">
        /// The new concept you want to extend. Must be an all-lowercase single word, or a space delimited compound word. Examples: 'foobarium', 'my custom concept'<br/>
        /// Example: foobarium
        /// </param>
        /// <param name="definition">
        /// A list of space-delimited words or a sentence describing what the custom concept is about. Avoid using the custom concept itself. An Example definition for the custom concept 'foobarium': would be 'a naturally occurring element which can only be seen by programmers'
        /// </param>
        /// <param name="weight">
        /// Weight of the definition of the new concept where 1='override existing definition entirely' and 0='ignore custom definition'. Note that if the custom concept is not present in the contextionary yet, the weight cannot be less than 1.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public C11yExtension(
            string? concept,
            string? definition,
            float? weight)
        {
            this.Concept = concept;
            this.Definition = definition;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yExtension" /> class.
        /// </summary>
        public C11yExtension()
        {
        }
    }
}
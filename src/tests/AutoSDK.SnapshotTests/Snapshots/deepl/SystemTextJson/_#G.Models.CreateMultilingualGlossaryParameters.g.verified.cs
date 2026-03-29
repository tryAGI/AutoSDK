//HintName: G.Models.CreateMultilingualGlossaryParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMultilingualGlossaryParameters
    {
        /// <summary>
        /// Name to be associated with the glossary.<br/>
        /// Example: My Glossary
        /// </summary>
        /// <example>My Glossary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Dictionaries to populate the glossary with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dictionaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GlossaryDictionary> Dictionaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultilingualGlossaryParameters" /> class.
        /// </summary>
        /// <param name="name">
        /// Name to be associated with the glossary.<br/>
        /// Example: My Glossary
        /// </param>
        /// <param name="dictionaries">
        /// Dictionaries to populate the glossary with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMultilingualGlossaryParameters(
            string name,
            global::System.Collections.Generic.IList<global::G.GlossaryDictionary> dictionaries)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Dictionaries = dictionaries ?? throw new global::System.ArgumentNullException(nameof(dictionaries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultilingualGlossaryParameters" /> class.
        /// </summary>
        public CreateMultilingualGlossaryParameters()
        {
        }
    }
}
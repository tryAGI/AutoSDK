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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Dictionaries to populate the glossary with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dictionaries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GlossaryDictionary> Dictionaries { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
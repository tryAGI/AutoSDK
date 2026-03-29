//HintName: G.Models.PatchMultilingualGlossaryParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchMultilingualGlossaryParameters
    {
        /// <summary>
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </summary>
        /// <example>def3a26b-3e84-45b3-84ae-0c0aaf3525f7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Dictionaries to edit the glossary with. Currently only supports 0 or 1 dictionaries in the array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dictionaries")]
        public global::System.Collections.Generic.IList<global::G.GlossaryDictionary>? Dictionaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMultilingualGlossaryParameters" /> class.
        /// </summary>
        /// <param name="name">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="dictionaries">
        /// Dictionaries to edit the glossary with. Currently only supports 0 or 1 dictionaries in the array.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchMultilingualGlossaryParameters(
            string? name,
            global::System.Collections.Generic.IList<global::G.GlossaryDictionary>? dictionaries)
        {
            this.Name = name;
            this.Dictionaries = dictionaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMultilingualGlossaryParameters" /> class.
        /// </summary>
        public PatchMultilingualGlossaryParameters()
        {
        }
    }
}
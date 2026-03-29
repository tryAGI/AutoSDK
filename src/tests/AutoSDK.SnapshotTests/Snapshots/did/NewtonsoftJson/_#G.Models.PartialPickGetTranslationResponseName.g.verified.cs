//HintName: G.Models.PartialPickGetTranslationResponseName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialPickGetTranslationResponseName
    {
        /// <summary>
        /// The name of the translation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPickGetTranslationResponseName" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the translation
        /// </param>
        public PartialPickGetTranslationResponseName(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialPickGetTranslationResponseName" /> class.
        /// </summary>
        public PartialPickGetTranslationResponseName()
        {
        }
    }
}
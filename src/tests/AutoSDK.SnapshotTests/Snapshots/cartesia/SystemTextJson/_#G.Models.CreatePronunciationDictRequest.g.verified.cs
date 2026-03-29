//HintName: G.Models.CreatePronunciationDictRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a new pronunciation dictionary
    /// </summary>
    public sealed partial class CreatePronunciationDictRequest
    {
        /// <summary>
        /// Name for the new pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional initial list of pronunciation mappings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::G.PronunciationDictItem>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePronunciationDictRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new pronunciation dictionary
        /// </param>
        /// <param name="items">
        /// Optional initial list of pronunciation mappings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePronunciationDictRequest(
            string name,
            global::System.Collections.Generic.IList<global::G.PronunciationDictItem>? items)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePronunciationDictRequest" /> class.
        /// </summary>
        public CreatePronunciationDictRequest()
        {
        }
    }
}
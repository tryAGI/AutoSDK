//HintName: G.Models.UpdatePronunciationDictRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an existing pronunciation dictionary
    /// </summary>
    public sealed partial class UpdatePronunciationDictRequest
    {
        /// <summary>
        /// New name for the pronunciation dictionary
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated list of pronunciation mappings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::System.Collections.Generic.IList<global::G.PronunciationDictItem>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePronunciationDictRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the pronunciation dictionary
        /// </param>
        /// <param name="items">
        /// Updated list of pronunciation mappings
        /// </param>
        public UpdatePronunciationDictRequest(
            string? name,
            global::System.Collections.Generic.IList<global::G.PronunciationDictItem>? items)
        {
            this.Name = name;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePronunciationDictRequest" /> class.
        /// </summary>
        public UpdatePronunciationDictRequest()
        {
        }
    }
}
//HintName: G.Models.VectorStoreSearchResultContentObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreSearchResultContentObject
    {
        /// <summary>
        /// The type of content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.VectorStoreSearchResultContentObjectType Type { get; set; }

        /// <summary>
        /// The text content returned from search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchResultContentObject" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content.
        /// </param>
        /// <param name="text">
        /// The text content returned from search.
        /// </param>
        public VectorStoreSearchResultContentObject(
            string text,
            global::G.VectorStoreSearchResultContentObjectType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchResultContentObject" /> class.
        /// </summary>
        public VectorStoreSearchResultContentObject()
        {
        }
    }
}
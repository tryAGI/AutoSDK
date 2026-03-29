//HintName: G.Models.StringList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User provided string values assigned to a single metadata key.
    /// </summary>
    public sealed partial class StringList
    {
        /// <summary>
        /// The string values of the metadata to store.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values")]
        public global::System.Collections.Generic.IList<string>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringList" /> class.
        /// </summary>
        /// <param name="values">
        /// The string values of the metadata to store.
        /// </param>
        public StringList(
            global::System.Collections.Generic.IList<string>? values)
        {
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringList" /> class.
        /// </summary>
        public StringList()
        {
        }
    }
}
//HintName: G.Models.DocumentData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A relevant documents that the model can cite to generate a more accurate reply. Each document is a string-string dictionary.
    /// </summary>
    public sealed partial class DocumentData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
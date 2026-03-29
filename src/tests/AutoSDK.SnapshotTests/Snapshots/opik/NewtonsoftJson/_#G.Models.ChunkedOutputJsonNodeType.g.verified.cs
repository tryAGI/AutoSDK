//HintName: G.Models.ChunkedOutputJsonNodeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkedOutputJsonNodeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("typeName")]
        public string? TypeName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedOutputJsonNodeType" /> class.
        /// </summary>
        /// <param name="typeName"></param>
        public ChunkedOutputJsonNodeType(
            string? typeName)
        {
            this.TypeName = typeName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedOutputJsonNodeType" /> class.
        /// </summary>
        public ChunkedOutputJsonNodeType()
        {
        }
    }
}
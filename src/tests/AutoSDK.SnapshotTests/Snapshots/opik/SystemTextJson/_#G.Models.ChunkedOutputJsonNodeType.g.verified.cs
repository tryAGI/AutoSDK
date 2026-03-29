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
        [global::System.Text.Json.Serialization.JsonPropertyName("typeName")]
        public string? TypeName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedOutputJsonNodeType" /> class.
        /// </summary>
        /// <param name="typeName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
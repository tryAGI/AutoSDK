//HintName: G.Models.GroundingChunkStringList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of string values.
    /// </summary>
    public sealed partial class GroundingChunkStringList
    {
        /// <summary>
        /// The string values of the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<string>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingChunkStringList" /> class.
        /// </summary>
        /// <param name="values">
        /// The string values of the list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundingChunkStringList(
            global::System.Collections.Generic.IList<string>? values)
        {
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingChunkStringList" /> class.
        /// </summary>
        public GroundingChunkStringList()
        {
        }
    }
}
//HintName: G.Models.ListElementsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListElementsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loras")]
        public global::System.Collections.Generic.IList<global::G.ListElementsResponseLora>? Loras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListElementsResponse" /> class.
        /// </summary>
        /// <param name="loras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListElementsResponse(
            global::System.Collections.Generic.IList<global::G.ListElementsResponseLora>? loras)
        {
            this.Loras = loras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListElementsResponse" /> class.
        /// </summary>
        public ListElementsResponse()
        {
        }
    }
}
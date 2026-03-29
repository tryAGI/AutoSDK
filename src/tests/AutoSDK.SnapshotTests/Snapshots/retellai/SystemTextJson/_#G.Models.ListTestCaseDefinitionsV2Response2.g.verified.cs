//HintName: G.Models.ListTestCaseDefinitionsV2Response2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTestCaseDefinitionsV2Response2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::G.TestCaseDefinition>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTestCaseDefinitionsV2Response2" /> class.
        /// </summary>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTestCaseDefinitionsV2Response2(
            global::System.Collections.Generic.IList<global::G.TestCaseDefinition>? items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTestCaseDefinitionsV2Response2" /> class.
        /// </summary>
        public ListTestCaseDefinitionsV2Response2()
        {
        }
    }
}
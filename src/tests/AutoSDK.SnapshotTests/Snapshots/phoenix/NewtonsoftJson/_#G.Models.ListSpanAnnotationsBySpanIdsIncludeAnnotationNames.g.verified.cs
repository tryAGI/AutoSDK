//HintName: G.Models.ListSpanAnnotationsBySpanIdsIncludeAnnotationNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional list of annotation names to include. If provided, only annotations with these names will be returned. 'note' annotations are excluded by default unless explicitly included in this list.
    /// </summary>
    public sealed partial class ListSpanAnnotationsBySpanIdsIncludeAnnotationNames
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
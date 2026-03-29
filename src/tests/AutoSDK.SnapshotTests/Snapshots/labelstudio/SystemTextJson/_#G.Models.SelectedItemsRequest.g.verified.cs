//HintName: G.Models.SelectedItemsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SelectedItemsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool All { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded")]
        public global::System.Collections.Generic.IList<int>? Excluded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<int>? Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedItemsRequest" /> class.
        /// </summary>
        /// <param name="all"></param>
        /// <param name="excluded"></param>
        /// <param name="included"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SelectedItemsRequest(
            bool all,
            global::System.Collections.Generic.IList<int>? excluded,
            global::System.Collections.Generic.IList<int>? included)
        {
            this.All = all;
            this.Excluded = excluded;
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedItemsRequest" /> class.
        /// </summary>
        public SelectedItemsRequest()
        {
        }
    }
}
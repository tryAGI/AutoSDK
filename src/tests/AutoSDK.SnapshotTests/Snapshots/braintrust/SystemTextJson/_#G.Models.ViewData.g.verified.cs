//HintName: G.Models.ViewData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The view definition
    /// </summary>
    public sealed partial class ViewData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public global::G.ViewDataSearch? Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_charts")]
        public object? CustomCharts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewData" /> class.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="customCharts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewData(
            global::G.ViewDataSearch? search,
            object? customCharts)
        {
            this.Search = search;
            this.CustomCharts = customCharts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewData" /> class.
        /// </summary>
        public ViewData()
        {
        }
    }
}
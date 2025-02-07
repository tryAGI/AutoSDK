//HintName: G.Models.ViewTraffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// View Traffic
    /// </summary>
    public sealed partial class ViewTraffic
    {
        /// <summary>
        /// Example: 14850
        /// </summary>
        /// <example>14850</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Example: 3782
        /// </summary>
        /// <example>3782</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniques")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Uniques { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("views")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Traffic> Views { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewTraffic" /> class.
        /// </summary>
        /// <param name="count">
        /// Example: 14850
        /// </param>
        /// <param name="uniques">
        /// Example: 3782
        /// </param>
        /// <param name="views"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewTraffic(
            int count,
            int uniques,
            global::System.Collections.Generic.IList<global::G.Traffic> views)
        {
            this.Count = count;
            this.Uniques = uniques;
            this.Views = views ?? throw new global::System.ArgumentNullException(nameof(views));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewTraffic" /> class.
        /// </summary>
        public ViewTraffic()
        {
        }
    }
}
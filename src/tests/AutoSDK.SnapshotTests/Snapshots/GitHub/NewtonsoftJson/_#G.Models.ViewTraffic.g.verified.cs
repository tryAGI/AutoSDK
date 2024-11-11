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
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Example: 3782
        /// </summary>
        /// <example>3782</example>
        [global::Newtonsoft.Json.JsonProperty("uniques", Required = global::Newtonsoft.Json.Required.Always)]
        public int Uniques { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("views", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Traffic> Views { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
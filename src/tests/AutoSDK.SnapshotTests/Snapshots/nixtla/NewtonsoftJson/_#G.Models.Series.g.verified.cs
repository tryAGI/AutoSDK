//HintName: G.Models.Series.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Series
    {
        /// <summary>
        /// Historic values of the target.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Y { get; set; } = default!;

        /// <summary>
        /// Sizes of the individual series.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sizes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Sizes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Series" /> class.
        /// </summary>
        /// <param name="y">
        /// Historic values of the target.
        /// </param>
        /// <param name="sizes">
        /// Sizes of the individual series.
        /// </param>
        public Series(
            global::System.Collections.Generic.IList<double> y,
            global::System.Collections.Generic.IList<int> sizes)
        {
            this.Y = y ?? throw new global::System.ArgumentNullException(nameof(y));
            this.Sizes = sizes ?? throw new global::System.ArgumentNullException(nameof(sizes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Series" /> class.
        /// </summary>
        public Series()
        {
        }
    }
}
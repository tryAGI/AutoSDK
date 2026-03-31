//HintName: G.Models.SeriesWithExogenous.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SeriesWithExogenous
    {
        /// <summary>
        /// Historic values of the exogenous features. Each feature must be a list of the same size as the target (y).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("X")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? X { get; set; }

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
        /// Initializes a new instance of the <see cref="SeriesWithExogenous" /> class.
        /// </summary>
        /// <param name="y">
        /// Historic values of the target.
        /// </param>
        /// <param name="sizes">
        /// Sizes of the individual series.
        /// </param>
        /// <param name="x">
        /// Historic values of the exogenous features. Each feature must be a list of the same size as the target (y).
        /// </param>
        public SeriesWithExogenous(
            global::System.Collections.Generic.IList<double> y,
            global::System.Collections.Generic.IList<int> sizes,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? x)
        {
            this.X = x;
            this.Y = y ?? throw new global::System.ArgumentNullException(nameof(y));
            this.Sizes = sizes ?? throw new global::System.ArgumentNullException(nameof(sizes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesWithExogenous" /> class.
        /// </summary>
        public SeriesWithExogenous()
        {
        }
    }
}
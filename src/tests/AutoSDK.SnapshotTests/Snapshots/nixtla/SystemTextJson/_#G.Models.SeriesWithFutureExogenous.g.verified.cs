//HintName: G.Models.SeriesWithFutureExogenous.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SeriesWithFutureExogenous
    {
        /// <summary>
        /// Future values of the exogenous features. Each feature must be a list of size number of series times the forecast horizon (h).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("X_future")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? XFuture { get; set; }

        /// <summary>
        /// Historic values of the exogenous features. Each feature must be a list of the same size as the target (y).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("X")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? X { get; set; }

        /// <summary>
        /// Historic values of the target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Y { get; set; }

        /// <summary>
        /// Sizes of the individual series.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Sizes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesWithFutureExogenous" /> class.
        /// </summary>
        /// <param name="y">
        /// Historic values of the target.
        /// </param>
        /// <param name="sizes">
        /// Sizes of the individual series.
        /// </param>
        /// <param name="xFuture">
        /// Future values of the exogenous features. Each feature must be a list of size number of series times the forecast horizon (h).
        /// </param>
        /// <param name="x">
        /// Historic values of the exogenous features. Each feature must be a list of the same size as the target (y).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SeriesWithFutureExogenous(
            global::System.Collections.Generic.IList<double> y,
            global::System.Collections.Generic.IList<int> sizes,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? xFuture,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? x)
        {
            this.XFuture = xFuture;
            this.X = x;
            this.Y = y ?? throw new global::System.ArgumentNullException(nameof(y));
            this.Sizes = sizes ?? throw new global::System.ArgumentNullException(nameof(sizes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesWithFutureExogenous" /> class.
        /// </summary>
        public SeriesWithFutureExogenous()
        {
        }
    }
}
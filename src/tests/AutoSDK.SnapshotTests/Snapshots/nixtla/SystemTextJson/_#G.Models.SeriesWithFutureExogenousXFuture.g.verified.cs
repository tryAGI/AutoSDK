//HintName: G.Models.SeriesWithFutureExogenousXFuture.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Future values of the exogenous features. Each feature must be a list of size number of series times the forecast horizon (h).
    /// </summary>
    public sealed partial class SeriesWithFutureExogenousXFuture
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
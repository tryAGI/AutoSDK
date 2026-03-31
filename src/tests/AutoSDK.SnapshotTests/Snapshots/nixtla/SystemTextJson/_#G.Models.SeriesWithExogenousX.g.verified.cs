//HintName: G.Models.SeriesWithExogenousX.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Historic values of the exogenous features. Each feature must be a list of the same size as the target (y).
    /// </summary>
    public sealed partial class SeriesWithExogenousX
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
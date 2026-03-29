//HintName: G.Models.BinaryQuantizationConfigQueryEncoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Asymmetric quantization configuration allows a query to have different quantization than stored vectors. It can increase the accuracy of search at the cost of performance.
    /// </summary>
    public sealed partial class BinaryQuantizationConfigQueryEncoding
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
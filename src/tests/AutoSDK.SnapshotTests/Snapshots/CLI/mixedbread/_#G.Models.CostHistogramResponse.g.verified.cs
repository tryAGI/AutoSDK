//HintName: G.Models.CostHistogramResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostHistogramResponse
    {
        /// <summary>
        /// The histogram of cost information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DailyCostBucket> Data { get; set; }

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: cost.histogram
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostHistogramResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The histogram of cost information
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: cost.histogram
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostHistogramResponse(
            global::System.Collections.Generic.IList<global::G.DailyCostBucket> data,
            string? @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostHistogramResponse" /> class.
        /// </summary>
        public CostHistogramResponse()
        {
        }
    }
}
//HintName: G.Models.SummarizeResponse6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizeResponse6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeResponse6" /> class.
        /// </summary>
        /// <param name="data"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SummarizeResponse6(
            string? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeResponse6" /> class.
        /// </summary>
        public SummarizeResponse6()
        {
        }
    }
}
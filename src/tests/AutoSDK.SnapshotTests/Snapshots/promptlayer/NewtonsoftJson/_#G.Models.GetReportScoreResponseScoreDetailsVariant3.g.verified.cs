//HintName: G.Models.GetReportScoreResponseScoreDetailsVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom score details
    /// </summary>
    public sealed partial class GetReportScoreResponseScoreDetailsVariant3
    {
        /// <summary>
        /// Score matrix from custom scoring logic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("matrix")]
        public byte[]? Matrix { get; set; }

        /// <summary>
        /// Custom scoring configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public object? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScoreDetailsVariant3" /> class.
        /// </summary>
        /// <param name="matrix">
        /// Score matrix from custom scoring logic
        /// </param>
        /// <param name="configuration">
        /// Custom scoring configuration
        /// </param>
        public GetReportScoreResponseScoreDetailsVariant3(
            byte[]? matrix,
            object? configuration)
        {
            this.Matrix = matrix;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScoreDetailsVariant3" /> class.
        /// </summary>
        public GetReportScoreResponseScoreDetailsVariant3()
        {
        }
    }
}
//HintName: G.Models.ModelRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ErrorRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SuccessRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRequestStatus" /> class.
        /// </summary>
        /// <param name="errorRate"></param>
        /// <param name="successRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelRequestStatus(
            double errorRate,
            double successRate)
        {
            this.ErrorRate = errorRate;
            this.SuccessRate = successRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRequestStatus" /> class.
        /// </summary>
        public ModelRequestStatus()
        {
        }
    }
}
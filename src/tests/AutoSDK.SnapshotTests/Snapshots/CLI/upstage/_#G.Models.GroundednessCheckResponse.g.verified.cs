//HintName: G.Models.GroundednessCheckResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroundednessCheckResponse
    {
        /// <summary>
        /// A unique identifier for the groundedness check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The model used for the groundedness check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Whether the answer is grounded in the provided context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounded")]
        public bool? Grounded { get; set; }

        /// <summary>
        /// A confidence score between 0 and 1 indicating the degree of groundedness.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Explanation for the groundedness determination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundednessCheckResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the groundedness check.
        /// </param>
        /// <param name="model">
        /// The model used for the groundedness check.
        /// </param>
        /// <param name="grounded">
        /// Whether the answer is grounded in the provided context.
        /// </param>
        /// <param name="score">
        /// A confidence score between 0 and 1 indicating the degree of groundedness.
        /// </param>
        /// <param name="reason">
        /// Explanation for the groundedness determination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundednessCheckResponse(
            string? id,
            string? model,
            bool? grounded,
            double? score,
            string? reason)
        {
            this.Id = id;
            this.Model = model;
            this.Grounded = grounded;
            this.Score = score;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundednessCheckResponse" /> class.
        /// </summary>
        public GroundednessCheckResponse()
        {
        }
    }
}
//HintName: G.Models.SingleGenerationTokenLikelihood.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleGenerationTokenLikelihood
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likelihood")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Likelihood { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleGenerationTokenLikelihood" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="likelihood"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SingleGenerationTokenLikelihood(
            string token,
            double likelihood)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Likelihood = likelihood;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleGenerationTokenLikelihood" /> class.
        /// </summary>
        public SingleGenerationTokenLikelihood()
        {
        }
    }
}
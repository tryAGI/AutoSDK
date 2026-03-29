//HintName: G.Models.GetTokenUsageResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTokenUsageResponseData
    {
        /// <summary>
        /// Number of tokens remaining for the team<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_tokens")]
        public double? RemainingTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenUsageResponseData" /> class.
        /// </summary>
        /// <param name="remainingTokens">
        /// Number of tokens remaining for the team<br/>
        /// Example: 1000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTokenUsageResponseData(
            double? remainingTokens)
        {
            this.RemainingTokens = remainingTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenUsageResponseData" /> class.
        /// </summary>
        public GetTokenUsageResponseData()
        {
        }
    }
}
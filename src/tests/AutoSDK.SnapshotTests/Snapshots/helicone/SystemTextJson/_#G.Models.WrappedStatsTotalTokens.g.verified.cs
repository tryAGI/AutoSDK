//HintName: G.Models.WrappedStatsTotalTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WrappedStatsTotalTokens
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheRead")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheWrite")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedStatsTotalTokens" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="cacheRead"></param>
        /// <param name="cacheWrite"></param>
        /// <param name="completion"></param>
        /// <param name="prompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WrappedStatsTotalTokens(
            double total,
            double cacheRead,
            double cacheWrite,
            double completion,
            double prompt)
        {
            this.Total = total;
            this.CacheRead = cacheRead;
            this.CacheWrite = cacheWrite;
            this.Completion = completion;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedStatsTotalTokens" /> class.
        /// </summary>
        public WrappedStatsTotalTokens()
        {
        }
    }
}
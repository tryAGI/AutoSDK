//HintName: G.Models.BetaExpiredResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaExpiredResult
    {
        /// <summary>
        /// Default Value: expired
        /// </summary>
        /// <default>global::G.BetaExpiredResultType.Expired</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaExpiredResultTypeJsonConverter))]
        public global::G.BetaExpiredResultType Type { get; set; } = global::G.BetaExpiredResultType.Expired;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExpiredResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: expired
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExpiredResult(
            global::G.BetaExpiredResultType type = global::G.BetaExpiredResultType.Expired)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExpiredResult" /> class.
        /// </summary>
        public BetaExpiredResult()
        {
        }
    }
}
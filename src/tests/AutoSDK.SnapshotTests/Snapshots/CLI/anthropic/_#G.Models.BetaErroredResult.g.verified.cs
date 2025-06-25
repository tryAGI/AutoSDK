//HintName: G.Models.BetaErroredResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaErroredResult
    {
        /// <summary>
        /// Default Value: errored
        /// </summary>
        /// <default>global::G.BetaErroredResultType.Errored</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaErroredResultTypeJsonConverter))]
        public global::G.BetaErroredResultType Type { get; set; } = global::G.BetaErroredResultType.Errored;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BetaErrorResponse Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErroredResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: errored
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaErroredResult(
            global::G.BetaErrorResponse error,
            global::G.BetaErroredResultType type = global::G.BetaErroredResultType.Errored)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErroredResult" /> class.
        /// </summary>
        public BetaErroredResult()
        {
        }
    }
}
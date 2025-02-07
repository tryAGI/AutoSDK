//HintName: G.Models.BetaSucceededResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaSucceededResult
    {
        /// <summary>
        /// Default Value: succeeded
        /// </summary>
        /// <default>global::G.BetaSucceededResultType.Succeeded</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaSucceededResultTypeJsonConverter))]
        public global::G.BetaSucceededResultType Type { get; set; } = global::G.BetaSucceededResultType.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BetaMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSucceededResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: succeeded
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSucceededResult(
            global::G.BetaMessage message,
            global::G.BetaSucceededResultType type = global::G.BetaSucceededResultType.Succeeded)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSucceededResult" /> class.
        /// </summary>
        public BetaSucceededResult()
        {
        }
    }
}
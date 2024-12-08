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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaSucceededResultType Type { get; set; } = global::G.BetaSucceededResultType.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BetaMessage Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSucceededResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: succeeded
        /// </param>
        /// <param name="message"></param>
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
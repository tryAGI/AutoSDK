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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BetaErroredResultTypeJsonConverter))]
        public global::G.BetaErroredResultType Type { get; set; } = global::G.BetaErroredResultType.Errored;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BetaErrorResponse Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErroredResult" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="type">
        /// Default Value: errored
        /// </param>
        public BetaErroredResult(
            global::G.BetaErrorResponse error,
            global::G.BetaErroredResultType type = global::G.BetaErroredResultType.Errored)
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErroredResult" /> class.
        /// </summary>
        public BetaErroredResult()
        {
        }
    }
}
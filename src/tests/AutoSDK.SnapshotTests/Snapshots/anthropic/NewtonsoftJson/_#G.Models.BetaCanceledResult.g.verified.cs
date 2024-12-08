//HintName: G.Models.BetaCanceledResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCanceledResult
    {
        /// <summary>
        /// Default Value: canceled
        /// </summary>
        /// <default>global::G.BetaCanceledResultType.Canceled</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaCanceledResultType Type { get; set; } = global::G.BetaCanceledResultType.Canceled;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCanceledResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: canceled
        /// </param>
        public BetaCanceledResult(
            global::G.BetaCanceledResultType type = global::G.BetaCanceledResultType.Canceled)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCanceledResult" /> class.
        /// </summary>
        public BetaCanceledResult()
        {
        }
    }
}
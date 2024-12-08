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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaExpiredResultType Type { get; set; } = global::G.BetaExpiredResultType.Expired;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExpiredResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: expired
        /// </param>
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
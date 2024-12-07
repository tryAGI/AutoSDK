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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaCanceledResultTypeJsonConverter))]
        public global::G.BetaCanceledResultType Type { get; set; } = global::G.BetaCanceledResultType.Canceled;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCanceledResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: canceled
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
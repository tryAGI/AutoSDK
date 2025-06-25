//HintName: G.Models.CanceledResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CanceledResult
    {
        /// <summary>
        /// Default Value: canceled
        /// </summary>
        /// <default>global::G.CanceledResultType.Canceled</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CanceledResultTypeJsonConverter))]
        public global::G.CanceledResultType Type { get; set; } = global::G.CanceledResultType.Canceled;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CanceledResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: canceled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CanceledResult(
            global::G.CanceledResultType type = global::G.CanceledResultType.Canceled)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CanceledResult" /> class.
        /// </summary>
        public CanceledResult()
        {
        }
    }
}
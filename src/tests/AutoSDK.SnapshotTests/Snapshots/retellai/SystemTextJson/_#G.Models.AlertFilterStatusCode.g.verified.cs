//HintName: G.Models.AlertFilterStatusCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API status codes to filter on (for API Error Count metrics).
    /// </summary>
    public sealed partial class AlertFilterStatusCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::G.AlertFilterStatusCodeValueItem>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertFilterStatusCode" /> class.
        /// </summary>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertFilterStatusCode(
            global::System.Collections.Generic.IList<global::G.AlertFilterStatusCodeValueItem>? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertFilterStatusCode" /> class.
        /// </summary>
        public AlertFilterStatusCode()
        {
        }
    }
}
//HintName: G.Models.CallStartReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallStartReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StartedCallSchemaForInsert Start { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStartReq" /> class.
        /// </summary>
        /// <param name="start"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallStartReq(
            global::G.StartedCallSchemaForInsert start)
        {
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStartReq" /> class.
        /// </summary>
        public CallStartReq()
        {
        }
    }
}
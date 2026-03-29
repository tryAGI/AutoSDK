//HintName: G.Models.CallReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallReadRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call")]
        public global::G.CallSchema? Call { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallReadRes" /> class.
        /// </summary>
        /// <param name="call"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallReadRes(
            global::G.CallSchema? call)
        {
            this.Call = call;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallReadRes" /> class.
        /// </summary>
        public CallReadRes()
        {
        }
    }
}
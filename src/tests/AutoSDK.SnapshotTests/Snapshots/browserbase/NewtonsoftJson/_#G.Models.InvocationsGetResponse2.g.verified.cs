//HintName: G.Models.InvocationsGetResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvocationsGetResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cause")]
        public global::G.InvocationsGetResponseCause? Cause { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvocationsGetResponse2" /> class.
        /// </summary>
        /// <param name="cause"></param>
        public InvocationsGetResponse2(
            global::G.InvocationsGetResponseCause? cause)
        {
            this.Cause = cause;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvocationsGetResponse2" /> class.
        /// </summary>
        public InvocationsGetResponse2()
        {
        }
    }
}
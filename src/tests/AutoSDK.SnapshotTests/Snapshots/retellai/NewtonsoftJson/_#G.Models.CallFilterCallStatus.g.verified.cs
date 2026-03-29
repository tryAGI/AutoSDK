//HintName: G.Models.CallFilterCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by call status.
    /// </summary>
    public sealed partial class CallFilterCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::System.Collections.Generic.IList<global::G.CallFilterCallStatusValueItem>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilterCallStatus" /> class.
        /// </summary>
        /// <param name="value"></param>
        public CallFilterCallStatus(
            global::System.Collections.Generic.IList<global::G.CallFilterCallStatusValueItem>? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilterCallStatus" /> class.
        /// </summary>
        public CallFilterCallStatus()
        {
        }
    }
}
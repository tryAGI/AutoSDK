//HintName: G.Models.CallFilterDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by call direction.
    /// </summary>
    public sealed partial class CallFilterDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::System.Collections.Generic.IList<global::G.CallFilterDirectionValueItem>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilterDirection" /> class.
        /// </summary>
        /// <param name="value"></param>
        public CallFilterDirection(
            global::System.Collections.Generic.IList<global::G.CallFilterDirectionValueItem>? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilterDirection" /> class.
        /// </summary>
        public CallFilterDirection()
        {
        }
    }
}
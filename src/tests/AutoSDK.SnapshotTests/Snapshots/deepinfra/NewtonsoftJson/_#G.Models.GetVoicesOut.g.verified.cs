//HintName: G.Models.GetVoicesOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voices")]
        public global::System.Collections.Generic.IList<global::G.Voice>? Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesOut" /> class.
        /// </summary>
        /// <param name="voices"></param>
        public GetVoicesOut(
            global::System.Collections.Generic.IList<global::G.Voice>? voices)
        {
            this.Voices = voices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesOut" /> class.
        /// </summary>
        public GetVoicesOut()
        {
        }
    }
}
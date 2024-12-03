//HintName: G.Models.ChecksUpdateRequestVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksUpdateRequestVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ChecksUpdateRequestVariant1Status? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksUpdateRequestVariant1" /> class.
        /// </summary>
        /// <param name="status"></param>
        public ChecksUpdateRequestVariant1(
            global::G.ChecksUpdateRequestVariant1Status? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksUpdateRequestVariant1" /> class.
        /// </summary>
        public ChecksUpdateRequestVariant1()
        {
        }
    }
}
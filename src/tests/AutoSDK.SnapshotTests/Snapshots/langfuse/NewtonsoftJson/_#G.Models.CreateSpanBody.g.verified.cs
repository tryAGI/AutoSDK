//HintName: G.Models.CreateSpanBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpanBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpanBody" /> class.
        /// </summary>
        /// <param name="endTime"></param>
        public CreateSpanBody(
            global::System.DateTime? endTime)
        {
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpanBody" /> class.
        /// </summary>
        public CreateSpanBody()
        {
        }
    }
}
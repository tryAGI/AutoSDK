//HintName: G.Models.CallEndReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallEndReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EndedCallSchemaForInsert End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallEndReq" /> class.
        /// </summary>
        /// <param name="end"></param>
        public CallEndReq(
            global::G.EndedCallSchemaForInsert end)
        {
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallEndReq" /> class.
        /// </summary>
        public CallEndReq()
        {
        }
    }
}
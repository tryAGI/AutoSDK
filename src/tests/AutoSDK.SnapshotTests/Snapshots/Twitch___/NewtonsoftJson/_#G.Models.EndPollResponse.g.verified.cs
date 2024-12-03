//HintName: G.Models.EndPollResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndPollResponse
    {
        /// <summary>
        /// A list that contains the poll that you ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Poll> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndPollResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the poll that you ended.
        /// </param>
        public EndPollResponse(
            global::System.Collections.Generic.IList<global::G.Poll> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndPollResponse" /> class.
        /// </summary>
        public EndPollResponse()
        {
        }
    }
}
//HintName: G.Models.CheckAutoModStatusBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckAutoModStatusBody
    {
        /// <summary>
        /// The list of messages to check. The list must contain at least one message and may contain up to a maximum of 100 messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CheckAutoModStatusBodyDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutoModStatusBody" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of messages to check. The list must contain at least one message and may contain up to a maximum of 100 messages.
        /// </param>
        public CheckAutoModStatusBody(
            global::System.Collections.Generic.IList<global::G.CheckAutoModStatusBodyDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutoModStatusBody" /> class.
        /// </summary>
        public CheckAutoModStatusBody()
        {
        }
    }
}
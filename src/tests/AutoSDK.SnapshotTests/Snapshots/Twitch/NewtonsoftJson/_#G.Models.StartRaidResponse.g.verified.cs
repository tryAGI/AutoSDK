//HintName: G.Models.StartRaidResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartRaidResponse
    {
        /// <summary>
        /// A list that contains a single object with information about the pending raid.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StartRaidResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartRaidResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains a single object with information about the pending raid.
        /// </param>
        public StartRaidResponse(
            global::System.Collections.Generic.IList<global::G.StartRaidResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartRaidResponse" /> class.
        /// </summary>
        public StartRaidResponse()
        {
        }
    }
}
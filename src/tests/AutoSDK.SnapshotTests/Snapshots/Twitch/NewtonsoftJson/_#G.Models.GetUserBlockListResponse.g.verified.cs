//HintName: G.Models.GetUserBlockListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserBlockListResponse
    {
        /// <summary>
        /// The list of blocked users. The list is in descending order by when the user was blocked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UserBlockList> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserBlockListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of blocked users. The list is in descending order by when the user was blocked.
        /// </param>
        public GetUserBlockListResponse(
            global::System.Collections.Generic.IList<global::G.UserBlockList> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserBlockListResponse" /> class.
        /// </summary>
        public GetUserBlockListResponse()
        {
        }
    }
}
//HintName: G.Models.GetUserChatColorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserChatColorResponse
    {
        /// <summary>
        /// The list of users and the color code they use for their name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UserChatColor> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserChatColorResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of users and the color code they use for their name.
        /// </param>
        public GetUserChatColorResponse(
            global::System.Collections.Generic.IList<global::G.UserChatColor> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserChatColorResponse" /> class.
        /// </summary>
        public GetUserChatColorResponse()
        {
        }
    }
}
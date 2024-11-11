//HintName: G.Models.GetUserAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserAdminResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserAdminResponse" /> class.
        /// </summary>
        /// <param name="user"></param>
        public GetUserAdminResponse(
            global::G.User? user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserAdminResponse" /> class.
        /// </summary>
        public GetUserAdminResponse()
        {
        }
    }
}
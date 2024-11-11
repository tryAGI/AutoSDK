//HintName: G.Models.UserServiceAddNewUserToAccountControllerOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserServiceAddNewUserToAccountControllerOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userData")]
        public global::G.User? UserData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userGroupLinkData")]
        public global::G.UserGroupLink? UserGroupLinkData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserServiceAddNewUserToAccountControllerOutput" /> class.
        /// </summary>
        /// <param name="userData"></param>
        /// <param name="userGroupLinkData"></param>
        public UserServiceAddNewUserToAccountControllerOutput(
            global::G.User? userData,
            global::G.UserGroupLink? userGroupLinkData)
        {
            this.UserData = userData;
            this.UserGroupLinkData = userGroupLinkData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserServiceAddNewUserToAccountControllerOutput" /> class.
        /// </summary>
        public UserServiceAddNewUserToAccountControllerOutput()
        {
        }
    }
}
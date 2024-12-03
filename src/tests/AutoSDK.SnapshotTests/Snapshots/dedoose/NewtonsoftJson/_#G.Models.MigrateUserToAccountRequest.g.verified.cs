//HintName: G.Models.MigrateUserToAccountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrateUserToAccountRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userToBeMovedId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserToBeMovedId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountIdToMoveTo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AccountIdToMoveTo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateUserToAccountRequest" /> class.
        /// </summary>
        /// <param name="userToBeMovedId"></param>
        /// <param name="accountIdToMoveTo"></param>
        public MigrateUserToAccountRequest(
            global::System.Guid userToBeMovedId,
            global::System.Guid accountIdToMoveTo)
        {
            this.UserToBeMovedId = userToBeMovedId;
            this.AccountIdToMoveTo = accountIdToMoveTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateUserToAccountRequest" /> class.
        /// </summary>
        public MigrateUserToAccountRequest()
        {
        }
    }
}
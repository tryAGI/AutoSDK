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
        [global::System.Text.Json.Serialization.JsonPropertyName("userToBeMovedId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserToBeMovedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountIdToMoveTo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountIdToMoveTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateUserToAccountRequest" /> class.
        /// </summary>
        /// <param name="userToBeMovedId"></param>
        /// <param name="accountIdToMoveTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
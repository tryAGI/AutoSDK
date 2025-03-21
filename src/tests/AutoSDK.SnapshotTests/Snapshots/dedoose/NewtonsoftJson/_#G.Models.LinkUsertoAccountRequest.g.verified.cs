﻿//HintName: G.Models.LinkUsertoAccountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkUsertoAccountRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AccountId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkUsertoAccountRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="accountId"></param>
        public LinkUsertoAccountRequest(
            global::System.Guid userId,
            global::System.Guid accountId)
        {
            this.UserId = userId;
            this.AccountId = accountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkUsertoAccountRequest" /> class.
        /// </summary>
        public LinkUsertoAccountRequest()
        {
        }
    }
}
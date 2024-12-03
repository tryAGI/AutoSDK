//HintName: G.Models.StartGetAccountProjectInfoJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartGetAccountProjectInfoJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGetAccountProjectInfoJobRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartGetAccountProjectInfoJobRequest(
            global::System.Guid accountId)
        {
            this.AccountId = accountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGetAccountProjectInfoJobRequest" /> class.
        /// </summary>
        public StartGetAccountProjectInfoJobRequest()
        {
        }
    }
}
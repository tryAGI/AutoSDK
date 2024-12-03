//HintName: G.Models.SetAccountStudentDiscountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetAccountStudentDiscountRequest
    {
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
        /// Initializes a new instance of the <see cref="SetAccountStudentDiscountRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        public SetAccountStudentDiscountRequest(
            global::System.Guid accountId)
        {
            this.AccountId = accountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAccountStudentDiscountRequest" /> class.
        /// </summary>
        public SetAccountStudentDiscountRequest()
        {
        }
    }
}
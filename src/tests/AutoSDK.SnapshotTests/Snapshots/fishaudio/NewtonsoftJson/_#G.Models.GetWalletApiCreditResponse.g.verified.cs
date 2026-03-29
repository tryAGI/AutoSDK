//HintName: G.Models.GetWalletApiCreditResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWalletApiCreditResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Credit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_phone_sha256", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasPhoneSha256 { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_free_credit")]
        public bool? HasFreeCredit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletApiCreditResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="credit"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="hasPhoneSha256"></param>
        /// <param name="hasFreeCredit">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public GetWalletApiCreditResponse(
            string id,
            string userId,
            string credit,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool hasPhoneSha256,
            bool? hasFreeCredit)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Credit = credit ?? throw new global::System.ArgumentNullException(nameof(credit));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.HasPhoneSha256 = hasPhoneSha256;
            this.HasFreeCredit = hasFreeCredit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletApiCreditResponse" /> class.
        /// </summary>
        public GetWalletApiCreditResponse()
        {
        }
    }
}
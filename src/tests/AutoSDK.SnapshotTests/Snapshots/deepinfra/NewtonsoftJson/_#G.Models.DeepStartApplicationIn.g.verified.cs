//HintName: G.Models.DeepStartApplicationIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeepStartApplicationIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company", Required = global::Newtonsoft.Json.Required.Always)]
        public string Company { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ceo", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ceo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("funding", Required = global::Newtonsoft.Json.Required.Always)]
        public string Funding { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("founded_on", Required = global::Newtonsoft.Json.Required.Always)]
        public string FoundedOn { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("website", Required = global::Newtonsoft.Json.Required.Always)]
        public string Website { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// Default Value: pending
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deal")]
        public string? Deal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepStartApplicationIn" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="uid"></param>
        /// <param name="company"></param>
        /// <param name="ceo"></param>
        /// <param name="funding"></param>
        /// <param name="foundedOn"></param>
        /// <param name="website"></param>
        /// <param name="createdAt"></param>
        /// <param name="status">
        /// Default Value: pending
        /// </param>
        /// <param name="deal"></param>
        public DeepStartApplicationIn(
            string company,
            string ceo,
            string funding,
            string foundedOn,
            string website,
            string? id,
            string? uid,
            int? createdAt,
            string? status,
            string? deal)
        {
            this.Company = company ?? throw new global::System.ArgumentNullException(nameof(company));
            this.Ceo = ceo ?? throw new global::System.ArgumentNullException(nameof(ceo));
            this.Funding = funding ?? throw new global::System.ArgumentNullException(nameof(funding));
            this.FoundedOn = foundedOn ?? throw new global::System.ArgumentNullException(nameof(foundedOn));
            this.Website = website ?? throw new global::System.ArgumentNullException(nameof(website));
            this.Id = id;
            this.Uid = uid;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Deal = deal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepStartApplicationIn" /> class.
        /// </summary>
        public DeepStartApplicationIn()
        {
        }
    }
}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ceo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ceo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("funding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Funding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("founded_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FoundedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// Default Value: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deal")]
        public string? Deal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
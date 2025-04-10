//HintName: G.Models.CustomerForRankResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerForRankResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentRankId")]
        public long? CurrentRankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryName")]
        public string? CountryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership365Active")]
        public bool? Membership365Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerForRankResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="currentRankId"></param>
        /// <param name="countryName"></param>
        /// <param name="username"></param>
        /// <param name="membership365Active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerForRankResponseDto(
            long? id,
            long? currentRankId,
            string? countryName,
            string? username,
            bool? membership365Active)
        {
            this.Id = id;
            this.CurrentRankId = currentRankId;
            this.CountryName = countryName;
            this.Username = username;
            this.Membership365Active = membership365Active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerForRankResponseDto" /> class.
        /// </summary>
        public CustomerForRankResponseDto()
        {
        }
    }
}
//HintName: G.Models.UpdateMakeCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMakeCredentialDTO
    {
        /// <summary>
        /// Team ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Region of your application. For example: eu1, eu2, us1, us2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMakeCredentialDTO" /> class.
        /// </summary>
        /// <param name="teamId">
        /// Team ID
        /// </param>
        /// <param name="region">
        /// Region of your application. For example: eu1, eu2, us1, us2
        /// </param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMakeCredentialDTO(
            string? teamId,
            string? region,
            string? apiKey,
            string? name)
        {
            this.TeamId = teamId;
            this.Region = region;
            this.ApiKey = apiKey;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMakeCredentialDTO" /> class.
        /// </summary>
        public UpdateMakeCredentialDTO()
        {
        }
    }
}
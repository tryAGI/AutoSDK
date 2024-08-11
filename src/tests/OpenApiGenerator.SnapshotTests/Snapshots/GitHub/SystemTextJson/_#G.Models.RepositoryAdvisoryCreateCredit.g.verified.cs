//HintName: G.Models.RepositoryAdvisoryCreateCredit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryCreateCredit
    {
        /// <summary>
        /// The username of the user credited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// The type of credit the user is receiving.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SecurityAdvisoryCreditTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SecurityAdvisoryCreditTypes Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
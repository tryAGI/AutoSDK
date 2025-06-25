﻿//HintName: G.Models.RepositoryAdvisoryCreateCredit.g.cs

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SecurityAdvisoryCreditTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SecurityAdvisoryCreditTypes Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreateCredit" /> class.
        /// </summary>
        /// <param name="login">
        /// The username of the user credited.
        /// </param>
        /// <param name="type">
        /// The type of credit the user is receiving.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryAdvisoryCreateCredit(
            string login,
            global::G.SecurityAdvisoryCreditTypes type)
        {
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCreateCredit" /> class.
        /// </summary>
        public RepositoryAdvisoryCreateCredit()
        {
        }
    }
}
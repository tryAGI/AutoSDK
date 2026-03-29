//HintName: G.Models.PANWPrismaParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PANWPrismaParameters
    {
        /// <summary>
        /// Prisma profile name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileName { get; set; }

        /// <summary>
        /// AI model identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model")]
        public string? AiModel { get; set; }

        /// <summary>
        /// Application user identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_user")]
        public string? AppUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PANWPrismaParameters" /> class.
        /// </summary>
        /// <param name="profileName">
        /// Prisma profile name
        /// </param>
        /// <param name="aiModel">
        /// AI model identifier
        /// </param>
        /// <param name="appUser">
        /// Application user identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PANWPrismaParameters(
            string profileName,
            string? aiModel,
            string? appUser)
        {
            this.ProfileName = profileName ?? throw new global::System.ArgumentNullException(nameof(profileName));
            this.AiModel = aiModel;
            this.AppUser = appUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PANWPrismaParameters" /> class.
        /// </summary>
        public PANWPrismaParameters()
        {
        }
    }
}
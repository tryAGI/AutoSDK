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
        [global::Newtonsoft.Json.JsonProperty("profile_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProfileName { get; set; } = default!;

        /// <summary>
        /// AI model identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model")]
        public string? AiModel { get; set; }

        /// <summary>
        /// Application user identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_user")]
        public string? AppUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
//HintName: G.Models.PropertiesDataPropertiesBasicInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDataPropertiesBasicInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PropertiesDataPropertiesBasicInfoUserLevelJsonConverter))]
        public global::G.PropertiesDataPropertiesBasicInfoUserLevel? UserLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBasicInfo" /> class.
        /// </summary>
        /// <param name="userLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesDataPropertiesBasicInfo(
            global::G.PropertiesDataPropertiesBasicInfoUserLevel? userLevel)
        {
            this.UserLevel = userLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBasicInfo" /> class.
        /// </summary>
        public PropertiesDataPropertiesBasicInfo()
        {
        }
    }
}
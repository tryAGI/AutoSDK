//HintName: G.Models.PropertiesDataPropertiesBasicInfoUserLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesDataPropertiesBasicInfoUserLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise")]
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="free")]
        Free,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pro_personal")]
        ProPersonal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team")]
        Team,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="v1_pro_instance")]
        V1ProInstance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesDataPropertiesBasicInfoUserLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesDataPropertiesBasicInfoUserLevel value)
        {
            return value switch
            {
                PropertiesDataPropertiesBasicInfoUserLevel.Enterprise => "enterprise",
                PropertiesDataPropertiesBasicInfoUserLevel.Free => "free",
                PropertiesDataPropertiesBasicInfoUserLevel.ProPersonal => "pro_personal",
                PropertiesDataPropertiesBasicInfoUserLevel.Team => "team",
                PropertiesDataPropertiesBasicInfoUserLevel.V1ProInstance => "v1_pro_instance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesDataPropertiesBasicInfoUserLevel? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => PropertiesDataPropertiesBasicInfoUserLevel.Enterprise,
                "free" => PropertiesDataPropertiesBasicInfoUserLevel.Free,
                "pro_personal" => PropertiesDataPropertiesBasicInfoUserLevel.ProPersonal,
                "team" => PropertiesDataPropertiesBasicInfoUserLevel.Team,
                "v1_pro_instance" => PropertiesDataPropertiesBasicInfoUserLevel.V1ProInstance,
                _ => null,
            };
        }
    }
}
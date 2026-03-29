//HintName: G.Models.HashicorpAppRoleAuthConfigVaultAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HashicorpAppRoleAuthConfigVaultAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approle")]
        Approle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HashicorpAppRoleAuthConfigVaultAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HashicorpAppRoleAuthConfigVaultAuthType value)
        {
            return value switch
            {
                HashicorpAppRoleAuthConfigVaultAuthType.Approle => "approle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HashicorpAppRoleAuthConfigVaultAuthType? ToEnum(string value)
        {
            return value switch
            {
                "approle" => HashicorpAppRoleAuthConfigVaultAuthType.Approle,
                _ => null,
            };
        }
    }
}
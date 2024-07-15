//HintName: G.Models.OrganizationDependabotSecretVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Visibility of a secret
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationDependabotSecretVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationDependabotSecretVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationDependabotSecretVisibility value)
        {
            return value switch
            {
                OrganizationDependabotSecretVisibility.All => "all",
                OrganizationDependabotSecretVisibility.Private => "private",
                OrganizationDependabotSecretVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationDependabotSecretVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrganizationDependabotSecretVisibility.All,
                "private" => OrganizationDependabotSecretVisibility.Private,
                "selected" => OrganizationDependabotSecretVisibility.Selected,
                _ => null,
            };
        }
    }
}
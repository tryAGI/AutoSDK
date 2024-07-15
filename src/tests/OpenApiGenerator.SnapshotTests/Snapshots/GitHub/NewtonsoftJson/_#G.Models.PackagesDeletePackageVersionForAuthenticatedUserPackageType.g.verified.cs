//HintName: G.Models.PackagesDeletePackageVersionForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesDeletePackageVersionForAuthenticatedUserPackageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="npm")]
        Npm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maven")]
        Maven,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rubygems")]
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="docker")]
        Docker,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nuget")]
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container")]
        Container,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesDeletePackageVersionForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageVersionForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Npm => "npm",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Maven => "maven",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Docker => "docker",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageVersionForAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Npm,
                "maven" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Nuget,
                "container" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Container,
                _ => null,
            };
        }
    }
}
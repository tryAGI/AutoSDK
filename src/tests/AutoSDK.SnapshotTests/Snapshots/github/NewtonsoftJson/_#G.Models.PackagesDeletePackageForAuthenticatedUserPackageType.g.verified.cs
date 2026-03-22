//HintName: G.Models.PackagesDeletePackageForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesDeletePackageForAuthenticatedUserPackageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container")]
        Container,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="docker")]
        Docker,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maven")]
        Maven,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="npm")]
        Npm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nuget")]
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rubygems")]
        Rubygems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesDeletePackageForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageForAuthenticatedUserPackageType.Container => "container",
                PackagesDeletePackageForAuthenticatedUserPackageType.Docker => "docker",
                PackagesDeletePackageForAuthenticatedUserPackageType.Maven => "maven",
                PackagesDeletePackageForAuthenticatedUserPackageType.Npm => "npm",
                PackagesDeletePackageForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesDeletePackageForAuthenticatedUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageForAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesDeletePackageForAuthenticatedUserPackageType.Container,
                "docker" => PackagesDeletePackageForAuthenticatedUserPackageType.Docker,
                "maven" => PackagesDeletePackageForAuthenticatedUserPackageType.Maven,
                "npm" => PackagesDeletePackageForAuthenticatedUserPackageType.Npm,
                "nuget" => PackagesDeletePackageForAuthenticatedUserPackageType.Nuget,
                "rubygems" => PackagesDeletePackageForAuthenticatedUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}
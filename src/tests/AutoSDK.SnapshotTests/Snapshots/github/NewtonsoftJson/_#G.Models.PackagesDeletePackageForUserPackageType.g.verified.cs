//HintName: G.Models.PackagesDeletePackageForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesDeletePackageForUserPackageType
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
    public static class PackagesDeletePackageForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageForUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageForUserPackageType.Container => "container",
                PackagesDeletePackageForUserPackageType.Docker => "docker",
                PackagesDeletePackageForUserPackageType.Maven => "maven",
                PackagesDeletePackageForUserPackageType.Npm => "npm",
                PackagesDeletePackageForUserPackageType.Nuget => "nuget",
                PackagesDeletePackageForUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesDeletePackageForUserPackageType.Container,
                "docker" => PackagesDeletePackageForUserPackageType.Docker,
                "maven" => PackagesDeletePackageForUserPackageType.Maven,
                "npm" => PackagesDeletePackageForUserPackageType.Npm,
                "nuget" => PackagesDeletePackageForUserPackageType.Nuget,
                "rubygems" => PackagesDeletePackageForUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}
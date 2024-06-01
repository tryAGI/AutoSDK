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
    public static class PackagesDeletePackageForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageForUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageForUserPackageType.Npm => "npm",
                PackagesDeletePackageForUserPackageType.Maven => "maven",
                PackagesDeletePackageForUserPackageType.Rubygems => "rubygems",
                PackagesDeletePackageForUserPackageType.Docker => "docker",
                PackagesDeletePackageForUserPackageType.Nuget => "nuget",
                PackagesDeletePackageForUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageForUserPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesDeletePackageForUserPackageType.Npm,
                "maven" => PackagesDeletePackageForUserPackageType.Maven,
                "rubygems" => PackagesDeletePackageForUserPackageType.Rubygems,
                "docker" => PackagesDeletePackageForUserPackageType.Docker,
                "nuget" => PackagesDeletePackageForUserPackageType.Nuget,
                "container" => PackagesDeletePackageForUserPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
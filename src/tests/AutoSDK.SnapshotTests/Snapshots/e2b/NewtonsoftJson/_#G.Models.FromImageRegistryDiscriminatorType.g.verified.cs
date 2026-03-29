//HintName: G.Models.FromImageRegistryDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FromImageRegistryDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aws")]
        Aws,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gcp")]
        Gcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="registry")]
        Registry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FromImageRegistryDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FromImageRegistryDiscriminatorType value)
        {
            return value switch
            {
                FromImageRegistryDiscriminatorType.Aws => "aws",
                FromImageRegistryDiscriminatorType.Gcp => "gcp",
                FromImageRegistryDiscriminatorType.Registry => "registry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FromImageRegistryDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => FromImageRegistryDiscriminatorType.Aws,
                "gcp" => FromImageRegistryDiscriminatorType.Gcp,
                "registry" => FromImageRegistryDiscriminatorType.Registry,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.AWSRegistryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of registry authentication
    /// </summary>
    public enum AWSRegistryType
    {
        /// <summary>
        /// 
        /// </summary>
        Aws,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AWSRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AWSRegistryType value)
        {
            return value switch
            {
                AWSRegistryType.Aws => "aws",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AWSRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => AWSRegistryType.Aws,
                _ => null,
            };
        }
    }
}
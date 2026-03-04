//HintName: G.Models.RepositoryRuleMaxFileSizeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleMaxFileSizeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_file_size")]
        MaxFileSize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleMaxFileSizeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleMaxFileSizeType value)
        {
            return value switch
            {
                RepositoryRuleMaxFileSizeType.MaxFileSize => "max_file_size",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleMaxFileSizeType? ToEnum(string value)
        {
            return value switch
            {
                "max_file_size" => RepositoryRuleMaxFileSizeType.MaxFileSize,
                _ => null,
            };
        }
    }
}
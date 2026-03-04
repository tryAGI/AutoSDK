//HintName: G.Models.RepositoryRuleMaxFilePathLengthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleMaxFilePathLengthType
    {
        /// <summary>
        /// 
        /// </summary>
        MaxFilePathLength,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleMaxFilePathLengthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleMaxFilePathLengthType value)
        {
            return value switch
            {
                RepositoryRuleMaxFilePathLengthType.MaxFilePathLength => "max_file_path_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleMaxFilePathLengthType? ToEnum(string value)
        {
            return value switch
            {
                "max_file_path_length" => RepositoryRuleMaxFilePathLengthType.MaxFilePathLength,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.RepositoryRuleVariant16Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleVariant16Type
    {
        /// <summary>
        /// 
        /// </summary>
        MaxFilePathLength,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleVariant16TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleVariant16Type value)
        {
            return value switch
            {
                RepositoryRuleVariant16Type.MaxFilePathLength => "max_file_path_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleVariant16Type? ToEnum(string value)
        {
            return value switch
            {
                "max_file_path_length" => RepositoryRuleVariant16Type.MaxFilePathLength,
                _ => null,
            };
        }
    }
}
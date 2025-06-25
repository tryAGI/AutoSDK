//HintName: G.Models.RepositoryRuleVariant17Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleVariant17Type
    {
        /// <summary>
        /// 
        /// </summary>
        MaxFilePathLength,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleVariant17TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleVariant17Type value)
        {
            return value switch
            {
                RepositoryRuleVariant17Type.MaxFilePathLength => "max_file_path_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleVariant17Type? ToEnum(string value)
        {
            return value switch
            {
                "max_file_path_length" => RepositoryRuleVariant17Type.MaxFilePathLength,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.RepositoryRuleVariant18Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleVariant18Type
    {
        /// <summary>
        /// 
        /// </summary>
        MaxFileSize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleVariant18TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleVariant18Type value)
        {
            return value switch
            {
                RepositoryRuleVariant18Type.MaxFileSize => "max_file_size",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleVariant18Type? ToEnum(string value)
        {
            return value switch
            {
                "max_file_size" => RepositoryRuleVariant18Type.MaxFileSize,
                _ => null,
            };
        }
    }
}
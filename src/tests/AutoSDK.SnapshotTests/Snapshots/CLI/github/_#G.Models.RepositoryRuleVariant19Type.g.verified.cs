//HintName: G.Models.RepositoryRuleVariant19Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleVariant19Type
    {
        /// <summary>
        /// 
        /// </summary>
        MaxFileSize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleVariant19TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleVariant19Type value)
        {
            return value switch
            {
                RepositoryRuleVariant19Type.MaxFileSize => "max_file_size",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleVariant19Type? ToEnum(string value)
        {
            return value switch
            {
                "max_file_size" => RepositoryRuleVariant19Type.MaxFileSize,
                _ => null,
            };
        }
    }
}
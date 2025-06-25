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
        FileExtensionRestriction,
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
                RepositoryRuleVariant18Type.FileExtensionRestriction => "file_extension_restriction",
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
                "file_extension_restriction" => RepositoryRuleVariant18Type.FileExtensionRestriction,
                _ => null,
            };
        }
    }
}
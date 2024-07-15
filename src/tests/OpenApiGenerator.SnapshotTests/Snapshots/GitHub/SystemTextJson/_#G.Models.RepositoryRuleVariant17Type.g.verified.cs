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
        FileExtensionRestriction,
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
                RepositoryRuleVariant17Type.FileExtensionRestriction => "file_extension_restriction",
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
                "file_extension_restriction" => RepositoryRuleVariant17Type.FileExtensionRestriction,
                _ => null,
            };
        }
    }
}
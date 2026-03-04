//HintName: G.Models.RepositoryRuleFileExtensionRestrictionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleFileExtensionRestrictionType
    {
        /// <summary>
        /// 
        /// </summary>
        FileExtensionRestriction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleFileExtensionRestrictionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleFileExtensionRestrictionType value)
        {
            return value switch
            {
                RepositoryRuleFileExtensionRestrictionType.FileExtensionRestriction => "file_extension_restriction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleFileExtensionRestrictionType? ToEnum(string value)
        {
            return value switch
            {
                "file_extension_restriction" => RepositoryRuleFileExtensionRestrictionType.FileExtensionRestriction,
                _ => null,
            };
        }
    }
}
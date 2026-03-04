//HintName: G.Models.RepositoryRuleFilePathRestrictionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleFilePathRestrictionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_path_restriction")]
        FilePathRestriction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleFilePathRestrictionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleFilePathRestrictionType value)
        {
            return value switch
            {
                RepositoryRuleFilePathRestrictionType.FilePathRestriction => "file_path_restriction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleFilePathRestrictionType? ToEnum(string value)
        {
            return value switch
            {
                "file_path_restriction" => RepositoryRuleFilePathRestrictionType.FilePathRestriction,
                _ => null,
            };
        }
    }
}
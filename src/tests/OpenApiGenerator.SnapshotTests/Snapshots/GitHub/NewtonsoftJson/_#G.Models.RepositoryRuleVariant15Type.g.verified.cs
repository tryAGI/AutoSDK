//HintName: G.Models.RepositoryRuleVariant15Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleVariant15Type
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
    public static class RepositoryRuleVariant15TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleVariant15Type value)
        {
            return value switch
            {
                RepositoryRuleVariant15Type.FilePathRestriction => "file_path_restriction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleVariant15Type? ToEnum(string value)
        {
            return value switch
            {
                "file_path_restriction" => RepositoryRuleVariant15Type.FilePathRestriction,
                _ => null,
            };
        }
    }
}
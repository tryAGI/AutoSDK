﻿//HintName: G.Models.RepositoryRuleVariant16Type.g.cs

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
        FilePathRestriction,
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
                RepositoryRuleVariant16Type.FilePathRestriction => "file_path_restriction",
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
                "file_path_restriction" => RepositoryRuleVariant16Type.FilePathRestriction,
                _ => null,
            };
        }
    }
}
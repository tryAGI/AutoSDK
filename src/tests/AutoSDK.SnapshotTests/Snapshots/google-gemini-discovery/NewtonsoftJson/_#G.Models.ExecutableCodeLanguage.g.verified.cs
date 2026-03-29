//HintName: G.Models.ExecutableCodeLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. Programming language of the `code`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExecutableCodeLanguage
    {
        /// <summary>
        /// Unspecified language. This value should not be used.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LANGUAGE_UNSPECIFIED")]
        LanguageUnspecified,
        /// <summary>
        /// Python &gt;= 3.10, with numpy and simpy available. Python is the default language.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PYTHON")]
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutableCodeLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutableCodeLanguage value)
        {
            return value switch
            {
                ExecutableCodeLanguage.LanguageUnspecified => "LANGUAGE_UNSPECIFIED",
                ExecutableCodeLanguage.Python => "PYTHON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutableCodeLanguage? ToEnum(string value)
        {
            return value switch
            {
                "LANGUAGE_UNSPECIFIED" => ExecutableCodeLanguage.LanguageUnspecified,
                "PYTHON" => ExecutableCodeLanguage.Python,
                _ => null,
            };
        }
    }
}
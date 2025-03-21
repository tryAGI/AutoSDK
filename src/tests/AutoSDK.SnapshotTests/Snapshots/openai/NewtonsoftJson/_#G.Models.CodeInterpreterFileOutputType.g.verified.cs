//HintName: G.Models.CodeInterpreterFileOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the code interpreter file output. Always `files`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeInterpreterFileOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="files")]
        Files,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterFileOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterFileOutputType value)
        {
            return value switch
            {
                CodeInterpreterFileOutputType.Files => "files",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterFileOutputType? ToEnum(string value)
        {
            return value switch
            {
                "files" => CodeInterpreterFileOutputType.Files,
                _ => null,
            };
        }
    }
}
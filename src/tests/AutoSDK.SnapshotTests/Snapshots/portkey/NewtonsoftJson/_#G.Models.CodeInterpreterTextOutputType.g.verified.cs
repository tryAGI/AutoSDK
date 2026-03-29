//HintName: G.Models.CodeInterpreterTextOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the code interpreter text output. Always `logs`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeInterpreterTextOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logs")]
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterTextOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterTextOutputType value)
        {
            return value switch
            {
                CodeInterpreterTextOutputType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterTextOutputType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => CodeInterpreterTextOutputType.Logs,
                _ => null,
            };
        }
    }
}
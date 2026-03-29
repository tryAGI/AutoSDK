//HintName: G.Models.ChatFormatPythonConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatFormatPythonConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="python")]
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFormatPythonConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFormatPythonConfigType value)
        {
            return value switch
            {
                ChatFormatPythonConfigType.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFormatPythonConfigType? ToEnum(string value)
        {
            return value switch
            {
                "python" => ChatFormatPythonConfigType.Python,
                _ => null,
            };
        }
    }
}
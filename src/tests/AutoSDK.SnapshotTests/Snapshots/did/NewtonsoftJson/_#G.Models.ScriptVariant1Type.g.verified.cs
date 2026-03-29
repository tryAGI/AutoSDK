//HintName: G.Models.ScriptVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScriptVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScriptVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScriptVariant1Type value)
        {
            return value switch
            {
                ScriptVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScriptVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ScriptVariant1Type.Text,
                _ => null,
            };
        }
    }
}
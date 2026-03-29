//HintName: G.Models.CreateTalkRequestScriptVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkRequestScriptVariant1Type
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
    public static class CreateTalkRequestScriptVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestScriptVariant1Type value)
        {
            return value switch
            {
                CreateTalkRequestScriptVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestScriptVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateTalkRequestScriptVariant1Type.Text,
                _ => null,
            };
        }
    }
}
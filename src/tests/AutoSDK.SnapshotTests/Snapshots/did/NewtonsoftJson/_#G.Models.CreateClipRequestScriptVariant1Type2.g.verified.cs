//HintName: G.Models.CreateClipRequestScriptVariant1Type2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipRequestScriptVariant1Type2
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
    public static class CreateClipRequestScriptVariant1Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestScriptVariant1Type2 value)
        {
            return value switch
            {
                CreateClipRequestScriptVariant1Type2.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestScriptVariant1Type2? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateClipRequestScriptVariant1Type2.Text,
                _ => null,
            };
        }
    }
}
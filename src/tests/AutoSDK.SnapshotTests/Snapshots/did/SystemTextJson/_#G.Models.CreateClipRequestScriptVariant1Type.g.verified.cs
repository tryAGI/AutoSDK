//HintName: G.Models.CreateClipRequestScriptVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum CreateClipRequestScriptVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipRequestScriptVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestScriptVariant1Type value)
        {
            return value switch
            {
                CreateClipRequestScriptVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestScriptVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateClipRequestScriptVariant1Type.Text,
                _ => null,
            };
        }
    }
}
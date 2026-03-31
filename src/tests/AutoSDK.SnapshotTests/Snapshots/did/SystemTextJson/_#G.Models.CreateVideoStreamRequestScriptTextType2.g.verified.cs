//HintName: G.Models.CreateVideoStreamRequestScriptTextType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum CreateVideoStreamRequestScriptTextType2
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoStreamRequestScriptTextType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptTextType2 value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptTextType2.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptTextType2? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateVideoStreamRequestScriptTextType2.Text,
                _ => null,
            };
        }
    }
}
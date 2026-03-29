//HintName: G.Models.CreateVideoStreamRequestScriptTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoStreamRequestScriptTextType
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
    public static class CreateVideoStreamRequestScriptTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptTextType value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateVideoStreamRequestScriptTextType.Text,
                _ => null,
            };
        }
    }
}
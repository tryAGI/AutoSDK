//HintName: G.Models.CreateVideoStreamRequestScriptTextProviderMicrosoftType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoStreamRequestScriptTextProviderMicrosoftType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoft")]
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoStreamRequestScriptTextProviderMicrosoftType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptTextProviderMicrosoftType2 value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptTextProviderMicrosoftType2.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptTextProviderMicrosoftType2? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => CreateVideoStreamRequestScriptTextProviderMicrosoftType2.Microsoft,
                _ => null,
            };
        }
    }
}
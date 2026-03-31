//HintName: G.Models.Create2RequestScriptTextProviderElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Create2RequestScriptTextProviderElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create2RequestScriptTextProviderElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2RequestScriptTextProviderElevenLabsType value)
        {
            return value switch
            {
                Create2RequestScriptTextProviderElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2RequestScriptTextProviderElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => Create2RequestScriptTextProviderElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}
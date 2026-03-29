//HintName: G.Models.ResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormat value)
        {
            return value switch
            {
                ResponseFormat.Anthropic => "ANTHROPIC",
                ResponseFormat.Google => "GOOGLE",
                ResponseFormat.Openai => "OPENAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => ResponseFormat.Anthropic,
                "GOOGLE" => ResponseFormat.Google,
                "OPENAI" => ResponseFormat.Openai,
                _ => null,
            };
        }
    }
}
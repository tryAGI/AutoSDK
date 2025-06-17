//HintName: G.Models.Chatv2RequestSafetyMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used to select the [safety instruction](https://docs.cohere.com/v2/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.<br/>
    /// When `OFF` is specified, the safety instruction will be omitted.<br/>
    /// Safety modes are not yet configurable in combination with `tools` and `documents` parameters.<br/>
    /// **Note**: This parameter is only compatible newer Cohere models, starting with [Command R 08-2024](https://docs.cohere.com/docs/command-r#august-2024-release) and [Command R+ 08-2024](https://docs.cohere.com/docs/command-r-plus#august-2024-release).<br/>
    /// **Note**: `command-r7b-12-2024` and newer models only support `"CONTEXTUAL"` and `"STRICT"` modes.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Chatv2RequestSafetyMode
    {
        /// <summary>
        /// //docs.cohere.com/v2/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTEXTUAL")]
        CONTEXTUAL,
        /// <summary>
        /// `command-r7b-12-2024` and newer models only support `"CONTEXTUAL"` and `"STRICT"` modes.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STRICT")]
        STRICT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OFF")]
        OFF,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Chatv2RequestSafetyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Chatv2RequestSafetyMode value)
        {
            return value switch
            {
                Chatv2RequestSafetyMode.CONTEXTUAL => "CONTEXTUAL",
                Chatv2RequestSafetyMode.STRICT => "STRICT",
                Chatv2RequestSafetyMode.OFF => "OFF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Chatv2RequestSafetyMode? ToEnum(string value)
        {
            return value switch
            {
                "CONTEXTUAL" => Chatv2RequestSafetyMode.CONTEXTUAL,
                "STRICT" => Chatv2RequestSafetyMode.STRICT,
                "OFF" => Chatv2RequestSafetyMode.OFF,
                _ => null,
            };
        }
    }
}
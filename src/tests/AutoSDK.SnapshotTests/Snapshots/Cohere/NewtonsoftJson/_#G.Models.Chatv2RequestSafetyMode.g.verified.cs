//HintName: G.Models.Chatv2RequestSafetyMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used to select the [safety instruction](/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.<br/>
    /// When `NONE` is specified, the safety instruction will be omitted.<br/>
    /// Safety modes are not yet configurable in combination with `tools`, `tool_results` and `documents` parameters.<br/>
    /// **Note**: This parameter is only compatible with models [Command R 08-2024](/docs/command-r#august-2024-release), [Command R+ 08-2024](/docs/command-r-plus#august-2024-release) and newer.<br/>
    /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Chatv2RequestSafetyMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTEXTUAL")]
        CONTEXTUAL,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STRICT")]
        STRICT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
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
                Chatv2RequestSafetyMode.NONE => "NONE",
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
                "NONE" => Chatv2RequestSafetyMode.NONE,
                _ => null,
            };
        }
    }
}
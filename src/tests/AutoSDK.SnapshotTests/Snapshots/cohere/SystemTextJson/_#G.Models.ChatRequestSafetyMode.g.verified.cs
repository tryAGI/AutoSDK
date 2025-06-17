﻿//HintName: G.Models.ChatRequestSafetyMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used to select the [safety instruction](https://docs.cohere.com/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.<br/>
    /// When `NONE` is specified, the safety instruction will be omitted.<br/>
    /// Safety modes are not yet configurable in combination with `tools`, `tool_results` and `documents` parameters.<br/>
    /// **Note**: This parameter is only compatible newer Cohere models, starting with [Command R 08-2024](https://docs.cohere.com/docs/command-r#august-2024-release) and [Command R+ 08-2024](https://docs.cohere.com/docs/command-r-plus#august-2024-release).<br/>
    /// **Note**: `command-r7b-12-2024` and newer models only support `"CONTEXTUAL"` and `"STRICT"` modes.<br/>
    /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
    /// </summary>
    public enum ChatRequestSafetyMode
    {
        /// <summary>
        /// //docs.cohere.com/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.
        /// </summary>
        CONTEXTUAL,
        /// <summary>
        /// `command-r7b-12-2024` and newer models only support `"CONTEXTUAL"` and `"STRICT"` modes.
        /// </summary>
        STRICT,
        /// <summary>
        /// 
        /// </summary>
        NONE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestSafetyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestSafetyMode value)
        {
            return value switch
            {
                ChatRequestSafetyMode.CONTEXTUAL => "CONTEXTUAL",
                ChatRequestSafetyMode.STRICT => "STRICT",
                ChatRequestSafetyMode.NONE => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestSafetyMode? ToEnum(string value)
        {
            return value switch
            {
                "CONTEXTUAL" => ChatRequestSafetyMode.CONTEXTUAL,
                "STRICT" => ChatRequestSafetyMode.STRICT,
                "NONE" => ChatRequestSafetyMode.NONE,
                _ => null,
            };
        }
    }
}
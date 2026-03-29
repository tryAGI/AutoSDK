//HintName: G.Models.FunctionCallingConfigMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Specifies the mode in which function calling should execute. If unspecified, the default value will be set to AUTO.
    /// </summary>
    public enum FunctionCallingConfigMode
    {
        /// <summary>
        /// Model is constrained to always predicting a function call only. If "allowed_function_names" are set, the predicted function call will be limited to any one of "allowed_function_names", else the predicted function call will be any one of the provided "function_declarations".
        /// </summary>
        Any,
        /// <summary>
        /// Default model behavior, model decides to predict either a function call or a natural language response.
        /// </summary>
        Auto,
        /// <summary>
        /// Unspecified function calling mode. This value should not be used.
        /// </summary>
        ModeUnspecified,
        /// <summary>
        /// Model will not predict any function call. Model behavior is same as when not passing any function declarations.
        /// </summary>
        None,
        /// <summary>
        /// Model decides to predict either a function call or a natural language response, but will validate function calls with constrained decoding. If "allowed_function_names" are set, the predicted function call will be limited to any one of "allowed_function_names", else the predicted function call will be any one of the provided "function_declarations".
        /// </summary>
        Validated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallingConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallingConfigMode value)
        {
            return value switch
            {
                FunctionCallingConfigMode.Any => "ANY",
                FunctionCallingConfigMode.Auto => "AUTO",
                FunctionCallingConfigMode.ModeUnspecified => "MODE_UNSPECIFIED",
                FunctionCallingConfigMode.None => "NONE",
                FunctionCallingConfigMode.Validated => "VALIDATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallingConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "ANY" => FunctionCallingConfigMode.Any,
                "AUTO" => FunctionCallingConfigMode.Auto,
                "MODE_UNSPECIFIED" => FunctionCallingConfigMode.ModeUnspecified,
                "NONE" => FunctionCallingConfigMode.None,
                "VALIDATED" => FunctionCallingConfigMode.Validated,
                _ => null,
            };
        }
    }
}
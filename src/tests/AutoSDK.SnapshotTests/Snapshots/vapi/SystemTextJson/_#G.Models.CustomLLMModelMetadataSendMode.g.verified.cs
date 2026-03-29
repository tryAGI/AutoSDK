//HintName: G.Models.CustomLLMModelMetadataSendMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This determines whether metadata is sent in requests to the custom provider.<br/>
    /// - `off` will not send any metadata. payload will look like `{ messages }`<br/>
    /// - `variable` will send `assistant.metadata` as a variable on the payload. payload will look like `{ messages, metadata }`<br/>
    /// - `destructured` will send `assistant.metadata` fields directly on the payload. payload will look like `{ messages, ...metadata }`<br/>
    /// Further, `variable` and `destructured` will send `call`, `phoneNumber`, and `customer` objects in the payload.<br/>
    /// Default is `variable`.
    /// </summary>
    public enum CustomLLMModelMetadataSendMode
    {
        /// <summary>
        /// 
        /// </summary>
        Destructured,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        Variable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomLLMModelMetadataSendModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomLLMModelMetadataSendMode value)
        {
            return value switch
            {
                CustomLLMModelMetadataSendMode.Destructured => "destructured",
                CustomLLMModelMetadataSendMode.Off => "off",
                CustomLLMModelMetadataSendMode.Variable => "variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomLLMModelMetadataSendMode? ToEnum(string value)
        {
            return value switch
            {
                "destructured" => CustomLLMModelMetadataSendMode.Destructured,
                "off" => CustomLLMModelMetadataSendMode.Off,
                "variable" => CustomLLMModelMetadataSendMode.Variable,
                _ => null,
            };
        }
    }
}
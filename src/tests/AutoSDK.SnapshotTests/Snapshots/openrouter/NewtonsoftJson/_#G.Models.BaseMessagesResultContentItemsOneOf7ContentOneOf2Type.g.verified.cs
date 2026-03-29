//HintName: G.Models.BaseMessagesResultContentItemsOneOf7ContentOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf7ContentOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="encrypted_code_execution_result")]
        EncryptedCodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf7ContentOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf7ContentOneOf2Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf7ContentOneOf2Type.EncryptedCodeExecutionResult => "encrypted_code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf7ContentOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted_code_execution_result" => BaseMessagesResultContentItemsOneOf7ContentOneOf2Type.EncryptedCodeExecutionResult,
                _ => null,
            };
        }
    }
}
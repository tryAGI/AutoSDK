//HintName: G.Models.PromptDataNullishToolFunctionVariant2GlobalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptDataNullishToolFunctionVariant2GlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global")]
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptDataNullishToolFunctionVariant2GlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDataNullishToolFunctionVariant2GlobalType value)
        {
            return value switch
            {
                PromptDataNullishToolFunctionVariant2GlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDataNullishToolFunctionVariant2GlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => PromptDataNullishToolFunctionVariant2GlobalType.Global,
                _ => null,
            };
        }
    }
}
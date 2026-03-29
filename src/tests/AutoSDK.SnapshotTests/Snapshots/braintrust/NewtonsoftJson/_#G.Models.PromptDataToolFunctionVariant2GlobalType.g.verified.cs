//HintName: G.Models.PromptDataToolFunctionVariant2GlobalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptDataToolFunctionVariant2GlobalType
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
    public static class PromptDataToolFunctionVariant2GlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDataToolFunctionVariant2GlobalType value)
        {
            return value switch
            {
                PromptDataToolFunctionVariant2GlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDataToolFunctionVariant2GlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => PromptDataToolFunctionVariant2GlobalType.Global,
                _ => null,
            };
        }
    }
}
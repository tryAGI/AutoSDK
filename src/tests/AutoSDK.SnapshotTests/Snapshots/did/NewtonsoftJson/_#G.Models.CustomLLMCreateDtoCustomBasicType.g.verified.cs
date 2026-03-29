//HintName: G.Models.CustomLLMCreateDtoCustomBasicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomLLMCreateDtoCustomBasicType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomLLMCreateDtoCustomBasicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomLLMCreateDtoCustomBasicType value)
        {
            return value switch
            {
                CustomLLMCreateDtoCustomBasicType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomLLMCreateDtoCustomBasicType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CustomLLMCreateDtoCustomBasicType.Basic,
                _ => null,
            };
        }
    }
}
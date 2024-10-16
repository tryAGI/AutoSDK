//HintName: G.Models.BlockDeltaDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BlockDeltaDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_delta")]
        TextDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_json_delta")]
        InputJsonDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlockDeltaDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlockDeltaDiscriminatorType value)
        {
            return value switch
            {
                BlockDeltaDiscriminatorType.TextDelta => "text_delta",
                BlockDeltaDiscriminatorType.InputJsonDelta => "input_json_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlockDeltaDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text_delta" => BlockDeltaDiscriminatorType.TextDelta,
                "input_json_delta" => BlockDeltaDiscriminatorType.InputJsonDelta,
                _ => null,
            };
        }
    }
}
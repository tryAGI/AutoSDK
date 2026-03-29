//HintName: G.Models.GetModelResponseTrainMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: full
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetModelResponseTrainMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="full")]
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelResponseTrainModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponseTrainMode value)
        {
            return value switch
            {
                GetModelResponseTrainMode.Fast => "fast",
                GetModelResponseTrainMode.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponseTrainMode? ToEnum(string value)
        {
            return value switch
            {
                "fast" => GetModelResponseTrainMode.Fast,
                "full" => GetModelResponseTrainMode.Full,
                _ => null,
            };
        }
    }
}
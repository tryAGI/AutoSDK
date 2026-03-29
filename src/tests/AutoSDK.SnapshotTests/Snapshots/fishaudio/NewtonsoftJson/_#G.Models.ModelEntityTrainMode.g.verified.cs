//HintName: G.Models.ModelEntityTrainMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: full
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelEntityTrainMode
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
    public static class ModelEntityTrainModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEntityTrainMode value)
        {
            return value switch
            {
                ModelEntityTrainMode.Fast => "fast",
                ModelEntityTrainMode.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEntityTrainMode? ToEnum(string value)
        {
            return value switch
            {
                "fast" => ModelEntityTrainMode.Fast,
                "full" => ModelEntityTrainMode.Full,
                _ => null,
            };
        }
    }
}
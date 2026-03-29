//HintName: G.Models.CreateModelResponseTrainMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: full
    /// </summary>
    public enum CreateModelResponseTrainMode
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelResponseTrainModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponseTrainMode value)
        {
            return value switch
            {
                CreateModelResponseTrainMode.Fast => "fast",
                CreateModelResponseTrainMode.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponseTrainMode? ToEnum(string value)
        {
            return value switch
            {
                "fast" => CreateModelResponseTrainMode.Fast,
                "full" => CreateModelResponseTrainMode.Full,
                _ => null,
            };
        }
    }
}
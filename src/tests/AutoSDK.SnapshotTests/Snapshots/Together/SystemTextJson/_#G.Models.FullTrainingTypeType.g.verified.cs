//HintName: G.Models.FullTrainingTypeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FullTrainingTypeType
    {
        /// <summary>
        /// 
        /// </summary>
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FullTrainingTypeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FullTrainingTypeType value)
        {
            return value switch
            {
                FullTrainingTypeType.Full => "Full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FullTrainingTypeType? ToEnum(string value)
        {
            return value switch
            {
                "Full" => FullTrainingTypeType.Full,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.PartialMappedEventDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PartialMappedEventDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Start,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialMappedEventDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialMappedEventDiscriminatorKind value)
        {
            return value switch
            {
                PartialMappedEventDiscriminatorKind.Start => "start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialMappedEventDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "start" => PartialMappedEventDiscriminatorKind.Start,
                _ => null,
            };
        }
    }
}
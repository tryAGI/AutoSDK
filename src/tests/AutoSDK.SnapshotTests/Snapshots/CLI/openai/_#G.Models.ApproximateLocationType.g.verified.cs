//HintName: G.Models.ApproximateLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of location approximation. Always `approximate`.<br/>
    /// Default Value: approximate
    /// </summary>
    public enum ApproximateLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApproximateLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApproximateLocationType value)
        {
            return value switch
            {
                ApproximateLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApproximateLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => ApproximateLocationType.Approximate,
                _ => null,
            };
        }
    }
}
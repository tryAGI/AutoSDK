//HintName: G.Models.CheckAvailabilityCalToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CheckAvailabilityCalToolType
    {
        /// <summary>
        /// 
        /// </summary>
        CheckAvailabilityCal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckAvailabilityCalToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckAvailabilityCalToolType value)
        {
            return value switch
            {
                CheckAvailabilityCalToolType.CheckAvailabilityCal => "check_availability_cal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckAvailabilityCalToolType? ToEnum(string value)
        {
            return value switch
            {
                "check_availability_cal" => CheckAvailabilityCalToolType.CheckAvailabilityCal,
                _ => null,
            };
        }
    }
}
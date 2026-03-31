//HintName: G.Models.TrainClipRequestGender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The gender of the presenter
    /// </summary>
    public enum TrainClipRequestGender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainClipRequestGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainClipRequestGender value)
        {
            return value switch
            {
                TrainClipRequestGender.Female => "female",
                TrainClipRequestGender.Male => "male",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainClipRequestGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => TrainClipRequestGender.Female,
                "male" => TrainClipRequestGender.Male,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.CreateClipTrainRequestGender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The gender of the presenter
    /// </summary>
    public enum CreateClipTrainRequestGender
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
    public static class CreateClipTrainRequestGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipTrainRequestGender value)
        {
            return value switch
            {
                CreateClipTrainRequestGender.Female => "female",
                CreateClipTrainRequestGender.Male => "male",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipTrainRequestGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => CreateClipTrainRequestGender.Female,
                "male" => CreateClipTrainRequestGender.Male,
                _ => null,
            };
        }
    }
}
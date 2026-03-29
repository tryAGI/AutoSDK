//HintName: G.Models.TrainClipResponseGender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TrainClipResponseGender
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="female")]
        Female,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="male")]
        Male,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainClipResponseGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainClipResponseGender value)
        {
            return value switch
            {
                TrainClipResponseGender.Female => "female",
                TrainClipResponseGender.Male => "male",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainClipResponseGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => TrainClipResponseGender.Female,
                "male" => TrainClipResponseGender.Male,
                _ => null,
            };
        }
    }
}
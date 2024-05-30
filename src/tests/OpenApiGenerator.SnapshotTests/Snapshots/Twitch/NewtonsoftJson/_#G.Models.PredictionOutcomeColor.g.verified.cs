//HintName: G.Models.PredictionOutcomeColor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The color that visually identifies this outcome in the UX. Possible values are:  
    ///   
    /// * BLUE
    /// * PINK
    ///   
    /// If the number of outcomes is two, the color is BLUE for the first outcome and PINK for the second outcome. If there are more than two outcomes, the color is BLUE for all outcomes.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PredictionOutcomeColor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLUE")]
        BLUE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PINK")]
        PINK,
    }

    public static class PredictionOutcomeColorExtensions
    {
        public static string ToValueString(this PredictionOutcomeColor value)
        {
            return value switch
            {
                PredictionOutcomeColor.BLUE => "BLUE",
                PredictionOutcomeColor.PINK => "PINK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PredictionOutcomeColor ToEnum(string value)
        {
            return value switch
            {
                "BLUE" => PredictionOutcomeColor.BLUE,
                "PINK" => PredictionOutcomeColor.PINK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PredictionOutcomeColor ToEnum(int value)
        {
            return value switch
            {
                0 => PredictionOutcomeColor.BLUE,
                1 => PredictionOutcomeColor.PINK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
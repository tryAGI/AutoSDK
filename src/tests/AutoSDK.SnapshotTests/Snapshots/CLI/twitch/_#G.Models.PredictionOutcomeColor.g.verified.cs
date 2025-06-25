//HintName: G.Models.PredictionOutcomeColor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The color that visually identifies this outcome in the UX. Possible values are:  <br/>
    ///   <br/>
    /// * BLUE<br/>
    /// * PINK<br/>
    ///   <br/>
    /// If the number of outcomes is two, the color is BLUE for the first outcome and PINK for the second outcome. If there are more than two outcomes, the color is BLUE for all outcomes.
    /// </summary>
    public enum PredictionOutcomeColor
    {
        /// <summary>
        /// 
        /// </summary>
        BLUE,
        /// <summary>
        /// 
        /// </summary>
        PINK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionOutcomeColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionOutcomeColor value)
        {
            return value switch
            {
                PredictionOutcomeColor.BLUE => "BLUE",
                PredictionOutcomeColor.PINK => "PINK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionOutcomeColor? ToEnum(string value)
        {
            return value switch
            {
                "BLUE" => PredictionOutcomeColor.BLUE,
                "PINK" => PredictionOutcomeColor.PINK,
                _ => null,
            };
        }
    }
}
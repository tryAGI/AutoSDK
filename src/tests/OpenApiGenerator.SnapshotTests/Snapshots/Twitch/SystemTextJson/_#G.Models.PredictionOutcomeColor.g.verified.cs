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
    public abstract class PredictionOutcomeColor
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BLUE = "BLUE";
        /// <summary>
        /// 
        /// </summary>
        public const string PINK = "PINK";
    }
}
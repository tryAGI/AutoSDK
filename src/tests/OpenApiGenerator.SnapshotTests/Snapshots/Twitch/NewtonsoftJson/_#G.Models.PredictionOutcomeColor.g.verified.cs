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
}
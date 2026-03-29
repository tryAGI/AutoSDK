//HintName: G.Models.StateEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `CO` - Connected<br/>
    /// * `DI` - Disconnected<br/>
    /// * `ER` - Error<br/>
    /// * `TR` - Training<br/>
    /// * `PR` - Predicting
    /// </summary>
    public enum StateEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Co,
        /// <summary>
        /// 
        /// </summary>
        Di,
        /// <summary>
        /// 
        /// </summary>
        Er,
        /// <summary>
        /// 
        /// </summary>
        Pr,
        /// <summary>
        /// 
        /// </summary>
        Tr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StateEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StateEnum value)
        {
            return value switch
            {
                StateEnum.Co => "CO",
                StateEnum.Di => "DI",
                StateEnum.Er => "ER",
                StateEnum.Pr => "PR",
                StateEnum.Tr => "TR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StateEnum? ToEnum(string value)
        {
            return value switch
            {
                "CO" => StateEnum.Co,
                "DI" => StateEnum.Di,
                "ER" => StateEnum.Er,
                "PR" => StateEnum.Pr,
                "TR" => StateEnum.Tr,
                _ => null,
            };
        }
    }
}
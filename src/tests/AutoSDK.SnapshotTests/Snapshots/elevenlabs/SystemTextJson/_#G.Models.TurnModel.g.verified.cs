//HintName: G.Models.TurnModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Version of the turn detection model to use.
    /// </summary>
    public enum TurnModel
    {
        /// <summary>
        /// 
        /// </summary>
        TurnV2,
        /// <summary>
        /// 
        /// </summary>
        TurnV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnModel value)
        {
            return value switch
            {
                TurnModel.TurnV2 => "turn_v2",
                TurnModel.TurnV3 => "turn_v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnModel? ToEnum(string value)
        {
            return value switch
            {
                "turn_v2" => TurnModel.TurnV2,
                "turn_v3" => TurnModel.TurnV3,
                _ => null,
            };
        }
    }
}
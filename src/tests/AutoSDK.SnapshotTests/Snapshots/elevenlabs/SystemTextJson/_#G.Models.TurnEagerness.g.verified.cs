//HintName: G.Models.TurnEagerness.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Agent's eagerness to respond. Higher values make agent wait for higher turn probability.
    /// </summary>
    public enum TurnEagerness
    {
        /// <summary>
        /// 
        /// </summary>
        Eager,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Patient,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnEagerness value)
        {
            return value switch
            {
                TurnEagerness.Eager => "eager",
                TurnEagerness.Normal => "normal",
                TurnEagerness.Patient => "patient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnEagerness? ToEnum(string value)
        {
            return value switch
            {
                "eager" => TurnEagerness.Eager,
                "normal" => TurnEagerness.Normal,
                "patient" => TurnEagerness.Patient,
                _ => null,
            };
        }
    }
}
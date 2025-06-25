//HintName: G.Models.TurnMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TurnMode
    {
        /// <summary>
        /// 
        /// </summary>
        Silence,
        /// <summary>
        /// 
        /// </summary>
        Turn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnMode value)
        {
            return value switch
            {
                TurnMode.Silence => "silence",
                TurnMode.Turn => "turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnMode? ToEnum(string value)
        {
            return value switch
            {
                "silence" => TurnMode.Silence,
                "turn" => TurnMode.Turn,
                _ => null,
            };
        }
    }
}
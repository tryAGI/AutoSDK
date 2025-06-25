//HintName: G.Models.MoveType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a move action, this property is <br/>
    /// always set to `move`.<br/>
    /// Default Value: move
    /// </summary>
    public enum MoveType
    {
        /// <summary>
        /// 
        /// </summary>
        Move,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MoveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveType value)
        {
            return value switch
            {
                MoveType.Move => "move",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveType? ToEnum(string value)
        {
            return value switch
            {
                "move" => MoveType.Move,
                _ => null,
            };
        }
    }
}
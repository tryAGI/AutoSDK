//HintName: G.Models.SkipTurnToolConfigSystemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: skip_turn
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SkipTurnToolConfigSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skip_turn")]
        SkipTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkipTurnToolConfigSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkipTurnToolConfigSystemToolType value)
        {
            return value switch
            {
                SkipTurnToolConfigSystemToolType.SkipTurn => "skip_turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkipTurnToolConfigSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "skip_turn" => SkipTurnToolConfigSystemToolType.SkipTurn,
                _ => null,
            };
        }
    }
}
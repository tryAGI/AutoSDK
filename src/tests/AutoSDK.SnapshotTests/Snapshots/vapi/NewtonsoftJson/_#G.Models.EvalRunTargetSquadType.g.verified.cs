//HintName: G.Models.EvalRunTargetSquadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the target.<br/>
    /// Currently it is fixed to `squad`.<br/>
    /// Example: squad
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalRunTargetSquadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="squad")]
        Squad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunTargetSquadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunTargetSquadType value)
        {
            return value switch
            {
                EvalRunTargetSquadType.Squad => "squad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunTargetSquadType? ToEnum(string value)
        {
            return value switch
            {
                "squad" => EvalRunTargetSquadType.Squad,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ReposGetClonesPer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: day
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposGetClonesPer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="day")]
        Day,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="week")]
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposGetClonesPerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetClonesPer value)
        {
            return value switch
            {
                ReposGetClonesPer.Day => "day",
                ReposGetClonesPer.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetClonesPer? ToEnum(string value)
        {
            return value switch
            {
                "day" => ReposGetClonesPer.Day,
                "week" => ReposGetClonesPer.Week,
                _ => null,
            };
        }
    }
}
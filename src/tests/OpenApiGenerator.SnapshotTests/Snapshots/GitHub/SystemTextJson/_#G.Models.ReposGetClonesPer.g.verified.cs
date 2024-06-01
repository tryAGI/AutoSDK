//HintName: G.Models.ReposGetClonesPer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: day
    /// </summary>
    public enum ReposGetClonesPer
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
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
        public static ReposGetClonesPer ToEnum(string value)
        {
            return value switch
            {
                "day" => ReposGetClonesPer.Day,
                "week" => ReposGetClonesPer.Week,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
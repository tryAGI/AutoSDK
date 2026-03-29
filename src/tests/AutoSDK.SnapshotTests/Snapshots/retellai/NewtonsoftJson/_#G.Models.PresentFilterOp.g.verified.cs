//HintName: G.Models.PresentFilterOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// pr: present (has value), np: not present
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PresentFilterOp
    {
        /// <summary>
        /// present (has value), np: not present
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="np")]
        Np,
        /// <summary>
        /// present (has value), np: not present
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pr")]
        Pr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PresentFilterOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresentFilterOp value)
        {
            return value switch
            {
                PresentFilterOp.Np => "np",
                PresentFilterOp.Pr => "pr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresentFilterOp? ToEnum(string value)
        {
            return value switch
            {
                "np" => PresentFilterOp.Np,
                "pr" => PresentFilterOp.Pr,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.PatchModelRequestVisibility3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchModelRequestVisibility3
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Unlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchModelRequestVisibility3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchModelRequestVisibility3 value)
        {
            return value switch
            {
                PatchModelRequestVisibility3.Private => "private",
                PatchModelRequestVisibility3.Public => "public",
                PatchModelRequestVisibility3.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchModelRequestVisibility3? ToEnum(string value)
        {
            return value switch
            {
                "private" => PatchModelRequestVisibility3.Private,
                "public" => PatchModelRequestVisibility3.Public,
                "unlist" => PatchModelRequestVisibility3.Unlist,
                _ => null,
            };
        }
    }
}
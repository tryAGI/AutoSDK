//HintName: G.Models.PatchModelRequestVisibility6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchModelRequestVisibility6
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
    public static class PatchModelRequestVisibility6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchModelRequestVisibility6 value)
        {
            return value switch
            {
                PatchModelRequestVisibility6.Private => "private",
                PatchModelRequestVisibility6.Public => "public",
                PatchModelRequestVisibility6.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchModelRequestVisibility6? ToEnum(string value)
        {
            return value switch
            {
                "private" => PatchModelRequestVisibility6.Private,
                "public" => PatchModelRequestVisibility6.Public,
                "unlist" => PatchModelRequestVisibility6.Unlist,
                _ => null,
            };
        }
    }
}
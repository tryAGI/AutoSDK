//HintName: G.Models.PatchModelRequestVisibility4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchModelRequestVisibility4
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
    public static class PatchModelRequestVisibility4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchModelRequestVisibility4 value)
        {
            return value switch
            {
                PatchModelRequestVisibility4.Private => "private",
                PatchModelRequestVisibility4.Public => "public",
                PatchModelRequestVisibility4.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchModelRequestVisibility4? ToEnum(string value)
        {
            return value switch
            {
                "private" => PatchModelRequestVisibility4.Private,
                "public" => PatchModelRequestVisibility4.Public,
                "unlist" => PatchModelRequestVisibility4.Unlist,
                _ => null,
            };
        }
    }
}
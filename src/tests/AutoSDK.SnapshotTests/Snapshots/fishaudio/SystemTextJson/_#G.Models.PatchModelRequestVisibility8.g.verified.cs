//HintName: G.Models.PatchModelRequestVisibility8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchModelRequestVisibility8
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
    public static class PatchModelRequestVisibility8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchModelRequestVisibility8 value)
        {
            return value switch
            {
                PatchModelRequestVisibility8.Private => "private",
                PatchModelRequestVisibility8.Public => "public",
                PatchModelRequestVisibility8.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchModelRequestVisibility8? ToEnum(string value)
        {
            return value switch
            {
                "private" => PatchModelRequestVisibility8.Private,
                "public" => PatchModelRequestVisibility8.Public,
                "unlist" => PatchModelRequestVisibility8.Unlist,
                _ => null,
            };
        }
    }
}
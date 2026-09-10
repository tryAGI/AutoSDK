//HintName: G.Models.PatchModelRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchModelRequestVisibility
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
    public static class PatchModelRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchModelRequestVisibility value)
        {
            return value switch
            {
                PatchModelRequestVisibility.Private => "private",
                PatchModelRequestVisibility.Public => "public",
                PatchModelRequestVisibility.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchModelRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => PatchModelRequestVisibility.Private,
                "public" => PatchModelRequestVisibility.Public,
                "unlist" => PatchModelRequestVisibility.Unlist,
                _ => null,
            };
        }
    }
}
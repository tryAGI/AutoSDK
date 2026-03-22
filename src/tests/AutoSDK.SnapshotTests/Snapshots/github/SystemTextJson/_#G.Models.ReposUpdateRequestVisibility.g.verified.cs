//HintName: G.Models.ReposUpdateRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of the repository.
    /// </summary>
    public enum ReposUpdateRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRequestVisibility value)
        {
            return value switch
            {
                ReposUpdateRequestVisibility.Private => "private",
                ReposUpdateRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ReposUpdateRequestVisibility.Private,
                "public" => ReposUpdateRequestVisibility.Public,
                _ => null,
            };
        }
    }
}
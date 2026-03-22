//HintName: G.Models.ReposCreateInOrgRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of the repository.
    /// </summary>
    public enum ReposCreateInOrgRequestVisibility
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
    public static class ReposCreateInOrgRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateInOrgRequestVisibility value)
        {
            return value switch
            {
                ReposCreateInOrgRequestVisibility.Private => "private",
                ReposCreateInOrgRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateInOrgRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ReposCreateInOrgRequestVisibility.Private,
                "public" => ReposCreateInOrgRequestVisibility.Public,
                _ => null,
            };
        }
    }
}
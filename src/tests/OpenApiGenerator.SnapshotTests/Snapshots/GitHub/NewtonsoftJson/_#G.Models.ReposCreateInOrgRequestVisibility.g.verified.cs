//HintName: G.Models.ReposCreateInOrgRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposCreateInOrgRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
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
                ReposCreateInOrgRequestVisibility.Public => "public",
                ReposCreateInOrgRequestVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateInOrgRequestVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => ReposCreateInOrgRequestVisibility.Public,
                "private" => ReposCreateInOrgRequestVisibility.Private,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
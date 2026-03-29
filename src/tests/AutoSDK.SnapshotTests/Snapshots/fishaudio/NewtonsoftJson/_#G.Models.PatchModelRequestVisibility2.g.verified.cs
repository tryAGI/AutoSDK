//HintName: G.Models.PatchModelRequestVisibility2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchModelRequestVisibility2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unlist")]
        Unlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchModelRequestVisibility2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchModelRequestVisibility2 value)
        {
            return value switch
            {
                PatchModelRequestVisibility2.Private => "private",
                PatchModelRequestVisibility2.Public => "public",
                PatchModelRequestVisibility2.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchModelRequestVisibility2? ToEnum(string value)
        {
            return value switch
            {
                "private" => PatchModelRequestVisibility2.Private,
                "public" => PatchModelRequestVisibility2.Public,
                "unlist" => PatchModelRequestVisibility2.Unlist,
                _ => null,
            };
        }
    }
}
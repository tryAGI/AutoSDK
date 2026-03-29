//HintName: G.Models.CreateModelResponseVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelResponseVisibility
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
    public static class CreateModelResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponseVisibility value)
        {
            return value switch
            {
                CreateModelResponseVisibility.Private => "private",
                CreateModelResponseVisibility.Public => "public",
                CreateModelResponseVisibility.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateModelResponseVisibility.Private,
                "public" => CreateModelResponseVisibility.Public,
                "unlist" => CreateModelResponseVisibility.Unlist,
                _ => null,
            };
        }
    }
}
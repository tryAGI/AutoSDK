//HintName: G.Models.ModelEntityVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelEntityVisibility
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
    public static class ModelEntityVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEntityVisibility value)
        {
            return value switch
            {
                ModelEntityVisibility.Private => "private",
                ModelEntityVisibility.Public => "public",
                ModelEntityVisibility.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEntityVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ModelEntityVisibility.Private,
                "public" => ModelEntityVisibility.Public,
                "unlist" => ModelEntityVisibility.Unlist,
                _ => null,
            };
        }
    }
}
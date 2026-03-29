//HintName: G.Models.CreateModelRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator<br/>
    /// Default Value: public
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelRequestVisibility
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
    public static class CreateModelRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestVisibility value)
        {
            return value switch
            {
                CreateModelRequestVisibility.Private => "private",
                CreateModelRequestVisibility.Public => "public",
                CreateModelRequestVisibility.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateModelRequestVisibility.Private,
                "public" => CreateModelRequestVisibility.Public,
                "unlist" => CreateModelRequestVisibility.Unlist,
                _ => null,
            };
        }
    }
}
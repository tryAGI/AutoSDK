//HintName: G.Models.ApiRequestToolMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiRequestToolMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DELETE")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GET")]
        Get,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PATCH")]
        Patch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POST")]
        Post,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PUT")]
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiRequestToolMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiRequestToolMethod value)
        {
            return value switch
            {
                ApiRequestToolMethod.Delete => "DELETE",
                ApiRequestToolMethod.Get => "GET",
                ApiRequestToolMethod.Patch => "PATCH",
                ApiRequestToolMethod.Post => "POST",
                ApiRequestToolMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiRequestToolMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => ApiRequestToolMethod.Delete,
                "GET" => ApiRequestToolMethod.Get,
                "PATCH" => ApiRequestToolMethod.Patch,
                "POST" => ApiRequestToolMethod.Post,
                "PUT" => ApiRequestToolMethod.Put,
                _ => null,
            };
        }
    }
}
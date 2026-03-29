//HintName: G.Models.CustomToolMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Method to use for the request, default to POST.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomToolMethod
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
    public static class CustomToolMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolMethod value)
        {
            return value switch
            {
                CustomToolMethod.Delete => "DELETE",
                CustomToolMethod.Get => "GET",
                CustomToolMethod.Patch => "PATCH",
                CustomToolMethod.Post => "POST",
                CustomToolMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => CustomToolMethod.Delete,
                "GET" => CustomToolMethod.Get,
                "PATCH" => CustomToolMethod.Patch,
                "POST" => CustomToolMethod.Post,
                "PUT" => CustomToolMethod.Put,
                _ => null,
            };
        }
    }
}
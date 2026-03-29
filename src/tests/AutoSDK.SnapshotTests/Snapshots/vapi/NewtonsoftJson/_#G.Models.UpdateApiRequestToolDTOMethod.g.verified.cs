//HintName: G.Models.UpdateApiRequestToolDTOMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateApiRequestToolDTOMethod
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
    public static class UpdateApiRequestToolDTOMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateApiRequestToolDTOMethod value)
        {
            return value switch
            {
                UpdateApiRequestToolDTOMethod.Delete => "DELETE",
                UpdateApiRequestToolDTOMethod.Get => "GET",
                UpdateApiRequestToolDTOMethod.Patch => "PATCH",
                UpdateApiRequestToolDTOMethod.Post => "POST",
                UpdateApiRequestToolDTOMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateApiRequestToolDTOMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => UpdateApiRequestToolDTOMethod.Delete,
                "GET" => UpdateApiRequestToolDTOMethod.Get,
                "PATCH" => UpdateApiRequestToolDTOMethod.Patch,
                "POST" => UpdateApiRequestToolDTOMethod.Post,
                "PUT" => UpdateApiRequestToolDTOMethod.Put,
                _ => null,
            };
        }
    }
}
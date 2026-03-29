//HintName: G.Models.ApiActivityLogsListMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiActivityLogsListMethod
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiActivityLogsListMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiActivityLogsListMethod value)
        {
            return value switch
            {
                ApiActivityLogsListMethod.Delete => "DELETE",
                ApiActivityLogsListMethod.Get => "GET",
                ApiActivityLogsListMethod.Patch => "PATCH",
                ApiActivityLogsListMethod.Post => "POST",
                ApiActivityLogsListMethod.Put => "PUT",
                ApiActivityLogsListMethod.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiActivityLogsListMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => ApiActivityLogsListMethod.Delete,
                "GET" => ApiActivityLogsListMethod.Get,
                "PATCH" => ApiActivityLogsListMethod.Patch,
                "POST" => ApiActivityLogsListMethod.Post,
                "PUT" => ApiActivityLogsListMethod.Put,
                "all" => ApiActivityLogsListMethod.All,
                _ => null,
            };
        }
    }
}
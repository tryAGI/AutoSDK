//HintName: G.Models.ApiActivityLogsListMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ApiActivityLogsListMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
        /// <summary>
        /// 
        /// </summary>
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
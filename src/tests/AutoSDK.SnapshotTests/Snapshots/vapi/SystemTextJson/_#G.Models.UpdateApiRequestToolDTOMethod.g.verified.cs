//HintName: G.Models.UpdateApiRequestToolDTOMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateApiRequestToolDTOMethod
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
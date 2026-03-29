//HintName: G.Models.CreateApiRequestToolDTOMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateApiRequestToolDTOMethod
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
    public static class CreateApiRequestToolDTOMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiRequestToolDTOMethod value)
        {
            return value switch
            {
                CreateApiRequestToolDTOMethod.Delete => "DELETE",
                CreateApiRequestToolDTOMethod.Get => "GET",
                CreateApiRequestToolDTOMethod.Patch => "PATCH",
                CreateApiRequestToolDTOMethod.Post => "POST",
                CreateApiRequestToolDTOMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiRequestToolDTOMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => CreateApiRequestToolDTOMethod.Delete,
                "GET" => CreateApiRequestToolDTOMethod.Get,
                "PATCH" => CreateApiRequestToolDTOMethod.Patch,
                "POST" => CreateApiRequestToolDTOMethod.Post,
                "PUT" => CreateApiRequestToolDTOMethod.Put,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ApiKeyRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Role of the API key. <br/>
    /// A serving API key can only perform query type requests on its corpora. A serving and<br/>
    /// indexing key can perform both indexing and query type requests on its corpora.<br/>
    /// A personal API key has all the same permissions as the creator of the API key.
    /// </summary>
    public enum ApiKeyRole
    {
        /// <summary>
        /// 
        /// </summary>
        Serving,
        /// <summary>
        /// 
        /// </summary>
        ServingAndIndexing,
        /// <summary>
        /// 
        /// </summary>
        Personal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyRole value)
        {
            return value switch
            {
                ApiKeyRole.Serving => "serving",
                ApiKeyRole.ServingAndIndexing => "serving_and_indexing",
                ApiKeyRole.Personal => "personal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyRole? ToEnum(string value)
        {
            return value switch
            {
                "serving" => ApiKeyRole.Serving,
                "serving_and_indexing" => ApiKeyRole.ServingAndIndexing,
                "personal" => ApiKeyRole.Personal,
                _ => null,
            };
        }
    }
}
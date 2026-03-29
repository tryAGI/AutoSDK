//HintName: G.Models.ApiKeyObjectListObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiKeyObjectListObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyObjectListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyObjectListObject value)
        {
            return value switch
            {
                ApiKeyObjectListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyObjectListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ApiKeyObjectListObject.List,
                _ => null,
            };
        }
    }
}
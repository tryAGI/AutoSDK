//HintName: G.Models.CreateSceneRequestDtoScriptTextProviderAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSceneRequestDtoScriptTextProviderAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSceneRequestDtoScriptTextProviderAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSceneRequestDtoScriptTextProviderAmazonType value)
        {
            return value switch
            {
                CreateSceneRequestDtoScriptTextProviderAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSceneRequestDtoScriptTextProviderAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => CreateSceneRequestDtoScriptTextProviderAmazonType.Amazon,
                _ => null,
            };
        }
    }
}
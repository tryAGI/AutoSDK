//HintName: G.Models.Create2RequestScriptTextProviderAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Create2RequestScriptTextProviderAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create2RequestScriptTextProviderAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2RequestScriptTextProviderAmazonType value)
        {
            return value switch
            {
                Create2RequestScriptTextProviderAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2RequestScriptTextProviderAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => Create2RequestScriptTextProviderAmazonType.Amazon,
                _ => null,
            };
        }
    }
}
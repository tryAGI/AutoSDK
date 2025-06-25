//HintName: G.Models.BaseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The possible types of fine-tuned models.<br/>
    ///  - BASE_TYPE_UNSPECIFIED: Unspecified model.<br/>
    ///  - BASE_TYPE_GENERATIVE: Deprecated: Generative model.<br/>
    ///  - BASE_TYPE_CLASSIFICATION: Classification model.<br/>
    ///  - BASE_TYPE_RERANK: Rerank model.<br/>
    ///  - BASE_TYPE_CHAT: Chat model.<br/>
    /// Default Value: BASE_TYPE_UNSPECIFIED
    /// </summary>
    public enum BaseType
    {
        /// <summary>
        /// Unspecified model.
        /// </summary>
        UNSPECIFIED,
        /// <summary>
        /// Deprecated: Generative model.
        /// </summary>
        GENERATIVE,
        /// <summary>
        /// Classification model.
        /// </summary>
        CLASSIFICATION,
        /// <summary>
        /// Rerank model.
        /// </summary>
        RERANK,
        /// <summary>
        /// Chat model.
        /// </summary>
        CHAT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseType value)
        {
            return value switch
            {
                BaseType.UNSPECIFIED => "BASE_TYPE_UNSPECIFIED",
                BaseType.GENERATIVE => "BASE_TYPE_GENERATIVE",
                BaseType.CLASSIFICATION => "BASE_TYPE_CLASSIFICATION",
                BaseType.RERANK => "BASE_TYPE_RERANK",
                BaseType.CHAT => "BASE_TYPE_CHAT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseType? ToEnum(string value)
        {
            return value switch
            {
                "BASE_TYPE_UNSPECIFIED" => BaseType.UNSPECIFIED,
                "BASE_TYPE_GENERATIVE" => BaseType.GENERATIVE,
                "BASE_TYPE_CLASSIFICATION" => BaseType.CLASSIFICATION,
                "BASE_TYPE_RERANK" => BaseType.RERANK,
                "BASE_TYPE_CHAT" => BaseType.CHAT,
                _ => null,
            };
        }
    }
}
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
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseType
    {
        /// <summary>
        /// Unspecified model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASE_TYPE_UNSPECIFIED")]
        Unspecified,
        /// <summary>
        /// Deprecated: Generative model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASE_TYPE_GENERATIVE")]
        Generative,
        /// <summary>
        /// Classification model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASE_TYPE_CLASSIFICATION")]
        Classification,
        /// <summary>
        /// Rerank model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASE_TYPE_RERANK")]
        Rerank,
        /// <summary>
        /// Chat model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASE_TYPE_CHAT")]
        Chat,
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
                BaseType.Unspecified => "BASE_TYPE_UNSPECIFIED",
                BaseType.Generative => "BASE_TYPE_GENERATIVE",
                BaseType.Classification => "BASE_TYPE_CLASSIFICATION",
                BaseType.Rerank => "BASE_TYPE_RERANK",
                BaseType.Chat => "BASE_TYPE_CHAT",
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
                "BASE_TYPE_UNSPECIFIED" => BaseType.Unspecified,
                "BASE_TYPE_GENERATIVE" => BaseType.Generative,
                "BASE_TYPE_CLASSIFICATION" => BaseType.Classification,
                "BASE_TYPE_RERANK" => BaseType.Rerank,
                "BASE_TYPE_CHAT" => BaseType.Chat,
                _ => null,
            };
        }
    }
}
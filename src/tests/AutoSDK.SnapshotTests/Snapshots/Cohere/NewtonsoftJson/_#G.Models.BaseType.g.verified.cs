//HintName: G.Models.BaseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The possible types of fine-tuned models.<br/>
    ///  - BASE_TYPE_UNSPECIFIED: Unspecified model.<br/>
    ///  - BASE_TYPE_GENERATIVE: Generative model.<br/>
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
        BASETYPEUNSPECIFIED,
        /// <summary>
        /// Generative model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASE_TYPE_GENERATIVE")]
        BASETYPEGENERATIVE,
        /// <summary>
        /// Classification model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASE_TYPE_CLASSIFICATION")]
        BASETYPECLASSIFICATION,
        /// <summary>
        /// Rerank model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASE_TYPE_RERANK")]
        BASETYPERERANK,
        /// <summary>
        /// Chat model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASE_TYPE_CHAT")]
        BASETYPECHAT,
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
                BaseType.BASETYPEUNSPECIFIED => "BASE_TYPE_UNSPECIFIED",
                BaseType.BASETYPEGENERATIVE => "BASE_TYPE_GENERATIVE",
                BaseType.BASETYPECLASSIFICATION => "BASE_TYPE_CLASSIFICATION",
                BaseType.BASETYPERERANK => "BASE_TYPE_RERANK",
                BaseType.BASETYPECHAT => "BASE_TYPE_CHAT",
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
                "BASE_TYPE_UNSPECIFIED" => BaseType.BASETYPEUNSPECIFIED,
                "BASE_TYPE_GENERATIVE" => BaseType.BASETYPEGENERATIVE,
                "BASE_TYPE_CLASSIFICATION" => BaseType.BASETYPECLASSIFICATION,
                "BASE_TYPE_RERANK" => BaseType.BASETYPERERANK,
                "BASE_TYPE_CHAT" => BaseType.BASETYPECHAT,
                _ => null,
            };
        }
    }
}
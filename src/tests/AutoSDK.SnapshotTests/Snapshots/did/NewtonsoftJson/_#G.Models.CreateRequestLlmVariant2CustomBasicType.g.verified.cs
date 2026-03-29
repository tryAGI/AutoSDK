//HintName: G.Models.CreateRequestLlmVariant2CustomBasicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestLlmVariant2CustomBasicType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRequestLlmVariant2CustomBasicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant2CustomBasicType value)
        {
            return value switch
            {
                CreateRequestLlmVariant2CustomBasicType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant2CustomBasicType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateRequestLlmVariant2CustomBasicType.Basic,
                _ => null,
            };
        }
    }
}
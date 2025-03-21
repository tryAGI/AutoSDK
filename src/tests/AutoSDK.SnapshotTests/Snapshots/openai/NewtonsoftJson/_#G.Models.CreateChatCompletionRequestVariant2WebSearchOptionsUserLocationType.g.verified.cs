//HintName: G.Models.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of location approximation. Always `approximate`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approximate")]
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType value)
        {
            return value switch
            {
                CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}
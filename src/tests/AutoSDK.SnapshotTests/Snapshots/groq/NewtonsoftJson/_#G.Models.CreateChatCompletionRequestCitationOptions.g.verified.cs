//HintName: G.Models.CreateChatCompletionRequestCitationOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to enable citations in the response. When enabled, the model will include citations for information retrieved from provided documents or web searches.<br/>
    /// Default Value: enabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestCitationOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestCitationOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestCitationOptions value)
        {
            return value switch
            {
                CreateChatCompletionRequestCitationOptions.Disabled => "disabled",
                CreateChatCompletionRequestCitationOptions.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestCitationOptions? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CreateChatCompletionRequestCitationOptions.Disabled,
                "enabled" => CreateChatCompletionRequestCitationOptions.Enabled,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ResponsePropertiesTruncation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The truncation strategy to use for the model response.<br/>
    /// - `auto`: If the context of this response and previous ones exceeds<br/>
    ///   the model's context window size, the model will truncate the <br/>
    ///   response to fit the context window by dropping input items in the<br/>
    ///   middle of the conversation. <br/>
    /// - `disabled` (default): If a model response will exceed the context window <br/>
    ///   size for a model, the request will fail with a 400 error.<br/>
    /// Default Value: disabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponsePropertiesTruncation
    {
        /// <summary>
        /// If the context of this response and previous ones exceeds
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// If a model response will exceed the context window
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsePropertiesTruncationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePropertiesTruncation value)
        {
            return value switch
            {
                ResponsePropertiesTruncation.Auto => "auto",
                ResponsePropertiesTruncation.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePropertiesTruncation? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsePropertiesTruncation.Auto,
                "disabled" => ResponsePropertiesTruncation.Disabled,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ResponseConfigToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the model chooses tools.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseConfigToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required")]
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseConfigToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseConfigToolChoice value)
        {
            return value switch
            {
                ResponseConfigToolChoice.Auto => "auto",
                ResponseConfigToolChoice.None => "none",
                ResponseConfigToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseConfigToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseConfigToolChoice.Auto,
                "none" => ResponseConfigToolChoice.None,
                "required" => ResponseConfigToolChoice.Required,
                _ => null,
            };
        }
    }
}
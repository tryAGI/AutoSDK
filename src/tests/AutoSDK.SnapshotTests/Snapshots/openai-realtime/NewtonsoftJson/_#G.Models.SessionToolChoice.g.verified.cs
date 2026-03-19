//HintName: G.Models.SessionToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the model chooses tools.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionToolChoice
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
    public static class SessionToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionToolChoice value)
        {
            return value switch
            {
                SessionToolChoice.Auto => "auto",
                SessionToolChoice.None => "none",
                SessionToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SessionToolChoice.Auto,
                "none" => SessionToolChoice.None,
                "required" => SessionToolChoice.Required,
                _ => null,
            };
        }
    }
}
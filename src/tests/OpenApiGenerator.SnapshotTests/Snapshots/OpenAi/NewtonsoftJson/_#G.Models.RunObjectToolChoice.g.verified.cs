//HintName: G.Models.RunObjectToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunObjectToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required")]
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunObjectToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunObjectToolChoice value)
        {
            return value switch
            {
                RunObjectToolChoice.None => "none",
                RunObjectToolChoice.Auto => "auto",
                RunObjectToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunObjectToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "none" => RunObjectToolChoice.None,
                "auto" => RunObjectToolChoice.Auto,
                "required" => RunObjectToolChoice.Required,
                _ => null,
            };
        }
    }
}
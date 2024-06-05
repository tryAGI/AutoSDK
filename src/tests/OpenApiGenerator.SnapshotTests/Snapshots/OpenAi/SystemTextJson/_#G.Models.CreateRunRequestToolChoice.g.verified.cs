//HintName: G.Models.CreateRunRequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
    /// </summary>
    public enum CreateRunRequestToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRunRequestToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRunRequestToolChoice value)
        {
            return value switch
            {
                CreateRunRequestToolChoice.None => "none",
                CreateRunRequestToolChoice.Auto => "auto",
                CreateRunRequestToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRunRequestToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateRunRequestToolChoice.None,
                "auto" => CreateRunRequestToolChoice.Auto,
                "required" => CreateRunRequestToolChoice.Required,
                _ => null,
            };
        }
    }
}
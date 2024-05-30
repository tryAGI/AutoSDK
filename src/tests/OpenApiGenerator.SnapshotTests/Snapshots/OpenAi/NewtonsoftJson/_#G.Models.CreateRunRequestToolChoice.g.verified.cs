//HintName: G.Models.CreateRunRequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRunRequestToolChoice
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

    public static class CreateRunRequestToolChoiceExtensions
    {
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
        public static CreateRunRequestToolChoice ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateRunRequestToolChoice.None,
                "auto" => CreateRunRequestToolChoice.Auto,
                "required" => CreateRunRequestToolChoice.Required,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateRunRequestToolChoice ToEnum(int value)
        {
            return value switch
            {
                0 => CreateRunRequestToolChoice.None,
                1 => CreateRunRequestToolChoice.Auto,
                2 => CreateRunRequestToolChoice.Required,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
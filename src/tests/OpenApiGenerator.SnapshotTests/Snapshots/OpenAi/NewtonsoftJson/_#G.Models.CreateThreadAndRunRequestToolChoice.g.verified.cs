//HintName: G.Models.CreateThreadAndRunRequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateThreadAndRunRequestToolChoice
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

    public static class CreateThreadAndRunRequestToolChoiceExtensions
    {
        public static string ToValueString(this CreateThreadAndRunRequestToolChoice value)
        {
            return value switch
            {
                CreateThreadAndRunRequestToolChoice.None => "none",
                CreateThreadAndRunRequestToolChoice.Auto => "auto",
                CreateThreadAndRunRequestToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateThreadAndRunRequestToolChoice ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateThreadAndRunRequestToolChoice.None,
                "auto" => CreateThreadAndRunRequestToolChoice.Auto,
                "required" => CreateThreadAndRunRequestToolChoice.Required,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateThreadAndRunRequestToolChoice ToEnum(int value)
        {
            return value switch
            {
                0 => CreateThreadAndRunRequestToolChoice.None,
                1 => CreateThreadAndRunRequestToolChoice.Auto,
                2 => CreateThreadAndRunRequestToolChoice.Required,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
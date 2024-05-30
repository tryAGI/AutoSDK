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

    public static class RunObjectToolChoiceExtensions
    {
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
        public static RunObjectToolChoice ToEnum(string value)
        {
            return value switch
            {
                "none" => RunObjectToolChoice.None,
                "auto" => RunObjectToolChoice.Auto,
                "required" => RunObjectToolChoice.Required,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectToolChoice ToEnum(int value)
        {
            return value switch
            {
                0 => RunObjectToolChoice.None,
                1 => RunObjectToolChoice.Auto,
                2 => RunObjectToolChoice.Required,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
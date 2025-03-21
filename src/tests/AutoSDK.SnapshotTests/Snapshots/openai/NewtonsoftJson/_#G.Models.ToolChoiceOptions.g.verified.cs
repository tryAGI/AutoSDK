//HintName: G.Models.ToolChoiceOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.<br/>
    /// `none` means the model will not call any tool and instead generates a message.<br/>
    /// `auto` means the model can pick between generating a message or calling one or<br/>
    /// more tools.<br/>
    /// `required` means the model must call one or more tools.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolChoiceOptions
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
    public static class ToolChoiceOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceOptions value)
        {
            return value switch
            {
                ToolChoiceOptions.None => "none",
                ToolChoiceOptions.Auto => "auto",
                ToolChoiceOptions.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceOptions? ToEnum(string value)
        {
            return value switch
            {
                "none" => ToolChoiceOptions.None,
                "auto" => ToolChoiceOptions.Auto,
                "required" => ToolChoiceOptions.Required,
                _ => null,
            };
        }
    }
}
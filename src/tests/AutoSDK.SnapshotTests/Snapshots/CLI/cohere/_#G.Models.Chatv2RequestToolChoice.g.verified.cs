//HintName: G.Models.Chatv2RequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used to control whether or not the model will be forced to use a tool when answering. When `REQUIRED` is specified, the model will be forced to use at least one of the user-defined tools, and the `tools` parameter must be passed in the request.<br/>
    /// When `NONE` is specified, the model will be forced **not** to use one of the specified tools, and give a direct response.<br/>
    /// If tool_choice isn't specified, then the model is free to choose whether to use the specified tools or not.<br/>
    /// **Note**: This parameter is only compatible with models [Command-r7b](https://docs.cohere.com/v2/docs/command-r7b) and newer.<br/>
    /// **Note**: The same functionality can be achieved in `/v1/chat` using the `force_single_step` parameter. If `force_single_step=true`, this is equivalent to specifying `REQUIRED`. While if `force_single_step=true` and `tool_results` are passed, this is equivalent to specifying `NONE`.
    /// </summary>
    public enum Chatv2RequestToolChoice
    {
        /// <summary>
        /// The same functionality can be achieved in `/v1/chat` using the `force_single_step` parameter. If `force_single_step=true`, this is equivalent to specifying `REQUIRED`. While if `force_single_step=true` and `tool_results` are passed, this is equivalent to specifying `NONE`.
        /// </summary>
        REQUIRED,
        /// <summary>
        /// The same functionality can be achieved in `/v1/chat` using the `force_single_step` parameter. If `force_single_step=true`, this is equivalent to specifying `REQUIRED`. While if `force_single_step=true` and `tool_results` are passed, this is equivalent to specifying `NONE`.
        /// </summary>
        NONE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Chatv2RequestToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Chatv2RequestToolChoice value)
        {
            return value switch
            {
                Chatv2RequestToolChoice.REQUIRED => "REQUIRED",
                Chatv2RequestToolChoice.NONE => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Chatv2RequestToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "REQUIRED" => Chatv2RequestToolChoice.REQUIRED,
                "NONE" => Chatv2RequestToolChoice.NONE,
                _ => null,
            };
        }
    }
}
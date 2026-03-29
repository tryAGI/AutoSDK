//HintName: G.Models.SelectorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SelectorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generic")]
        Generic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_image")]
        InputImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_parameter")]
        InputParameter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="step_output")]
        StepOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="step_output_image")]
        StepOutputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelectorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelectorType value)
        {
            return value switch
            {
                SelectorType.Generic => "generic",
                SelectorType.InputImage => "input_image",
                SelectorType.InputParameter => "input_parameter",
                SelectorType.StepOutput => "step_output",
                SelectorType.StepOutputImage => "step_output_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelectorType? ToEnum(string value)
        {
            return value switch
            {
                "generic" => SelectorType.Generic,
                "input_image" => SelectorType.InputImage,
                "input_parameter" => SelectorType.InputParameter,
                "step_output" => SelectorType.StepOutput,
                "step_output_image" => SelectorType.StepOutputImage,
                _ => null,
            };
        }
    }
}
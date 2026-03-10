//HintName: G.Models.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType value)
        {
            return value switch
            {
                WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType.Dynamic => "dynamic",
                WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType.Dynamic,
                "static" => WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType.Static,
                _ => null,
            };
        }
    }
}
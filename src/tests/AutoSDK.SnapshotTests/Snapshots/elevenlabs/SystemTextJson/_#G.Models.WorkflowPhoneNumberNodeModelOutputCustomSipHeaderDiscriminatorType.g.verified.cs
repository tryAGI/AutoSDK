//HintName: G.Models.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType
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
    public static class WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType value)
        {
            return value switch
            {
                WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType.Dynamic => "dynamic",
                WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType.Dynamic,
                "static" => WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}
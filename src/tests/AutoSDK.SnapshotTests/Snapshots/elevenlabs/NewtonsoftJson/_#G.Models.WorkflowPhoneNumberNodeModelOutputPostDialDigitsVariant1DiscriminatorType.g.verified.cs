//HintName: G.Models.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic")]
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="static")]
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType value)
        {
            return value switch
            {
                WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType.Dynamic => "dynamic",
                WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType.Dynamic,
                "static" => WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType.Static,
                _ => null,
            };
        }
    }
}
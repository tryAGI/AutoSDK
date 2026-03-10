//HintName: G.Models.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Phone,
        /// <summary>
        /// 
        /// </summary>
        PhoneDynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        SipUri,
        /// <summary>
        /// 
        /// </summary>
        SipUriDynamicVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType.Phone => "phone",
                WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType.SipUri => "sip_uri",
                WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType.SipUriDynamicVariable => "sip_uri_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                "sip_uri" => WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType.SipUri,
                "sip_uri_dynamic_variable" => WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorType.SipUriDynamicVariable,
                _ => null,
            };
        }
    }
}
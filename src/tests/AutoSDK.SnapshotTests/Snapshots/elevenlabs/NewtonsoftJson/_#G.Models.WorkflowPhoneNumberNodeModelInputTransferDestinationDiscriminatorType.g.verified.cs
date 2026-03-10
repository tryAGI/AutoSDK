//HintName: G.Models.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone")]
        Phone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone_dynamic_variable")]
        PhoneDynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_uri")]
        SipUri,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_uri_dynamic_variable")]
        SipUriDynamicVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType.Phone => "phone",
                WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType.SipUri => "sip_uri",
                WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType.SipUriDynamicVariable => "sip_uri_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                "sip_uri" => WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType.SipUri,
                "sip_uri_dynamic_variable" => WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType.SipUriDynamicVariable,
                _ => null,
            };
        }
    }
}
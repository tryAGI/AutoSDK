//HintName: G.Models.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType
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
    public static class WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType value)
        {
            return value switch
            {
                WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType.Dynamic => "dynamic",
                WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType.Dynamic,
                "static" => WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}
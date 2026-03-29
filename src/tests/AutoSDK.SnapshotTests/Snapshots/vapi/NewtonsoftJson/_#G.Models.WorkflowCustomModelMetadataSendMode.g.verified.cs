//HintName: G.Models.WorkflowCustomModelMetadataSendMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This determines whether metadata is sent in requests to the custom provider.<br/>
    /// - `off` will not send any metadata. payload will look like `{ messages }`<br/>
    /// - `variable` will send `assistant.metadata` as a variable on the payload. payload will look like `{ messages, metadata }`<br/>
    /// - `destructured` will send `assistant.metadata` fields directly on the payload. payload will look like `{ messages, ...metadata }`<br/>
    /// Further, `variable` and `destructured` will send `call`, `phoneNumber`, and `customer` objects in the payload.<br/>
    /// Default is `variable`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowCustomModelMetadataSendMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="destructured")]
        Destructured,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="variable")]
        Variable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowCustomModelMetadataSendModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowCustomModelMetadataSendMode value)
        {
            return value switch
            {
                WorkflowCustomModelMetadataSendMode.Destructured => "destructured",
                WorkflowCustomModelMetadataSendMode.Off => "off",
                WorkflowCustomModelMetadataSendMode.Variable => "variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowCustomModelMetadataSendMode? ToEnum(string value)
        {
            return value switch
            {
                "destructured" => WorkflowCustomModelMetadataSendMode.Destructured,
                "off" => WorkflowCustomModelMetadataSendMode.Off,
                "variable" => WorkflowCustomModelMetadataSendMode.Variable,
                _ => null,
            };
        }
    }
}
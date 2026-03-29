//HintName: G.Models.OpenAPIWorkflowMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAPIWorkflowMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chatflow")]
        Chatflow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow")]
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAPIWorkflowModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAPIWorkflowMode value)
        {
            return value switch
            {
                OpenAPIWorkflowMode.Chatflow => "chatflow",
                OpenAPIWorkflowMode.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAPIWorkflowMode? ToEnum(string value)
        {
            return value switch
            {
                "chatflow" => OpenAPIWorkflowMode.Chatflow,
                "workflow" => OpenAPIWorkflowMode.Workflow,
                _ => null,
            };
        }
    }
}
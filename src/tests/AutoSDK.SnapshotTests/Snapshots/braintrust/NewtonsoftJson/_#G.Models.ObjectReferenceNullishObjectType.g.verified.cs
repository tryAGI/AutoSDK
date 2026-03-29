//HintName: G.Models.ObjectReferenceNullishObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the object the event is originating from.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectReferenceNullishObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_logs")]
        ProjectLogs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_session")]
        PromptSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectReferenceNullishObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectReferenceNullishObjectType value)
        {
            return value switch
            {
                ObjectReferenceNullishObjectType.Dataset => "dataset",
                ObjectReferenceNullishObjectType.Experiment => "experiment",
                ObjectReferenceNullishObjectType.Function => "function",
                ObjectReferenceNullishObjectType.ProjectLogs => "project_logs",
                ObjectReferenceNullishObjectType.Prompt => "prompt",
                ObjectReferenceNullishObjectType.PromptSession => "prompt_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectReferenceNullishObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ObjectReferenceNullishObjectType.Dataset,
                "experiment" => ObjectReferenceNullishObjectType.Experiment,
                "function" => ObjectReferenceNullishObjectType.Function,
                "project_logs" => ObjectReferenceNullishObjectType.ProjectLogs,
                "prompt" => ObjectReferenceNullishObjectType.Prompt,
                "prompt_session" => ObjectReferenceNullishObjectType.PromptSession,
                _ => null,
            };
        }
    }
}
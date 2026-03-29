//HintName: G.Models.InvokeParentSpanParentStructObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InvokeParentSpanParentStructObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playground_logs")]
        PlaygroundLogs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_logs")]
        ProjectLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvokeParentSpanParentStructObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvokeParentSpanParentStructObjectType value)
        {
            return value switch
            {
                InvokeParentSpanParentStructObjectType.Experiment => "experiment",
                InvokeParentSpanParentStructObjectType.PlaygroundLogs => "playground_logs",
                InvokeParentSpanParentStructObjectType.ProjectLogs => "project_logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvokeParentSpanParentStructObjectType? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => InvokeParentSpanParentStructObjectType.Experiment,
                "playground_logs" => InvokeParentSpanParentStructObjectType.PlaygroundLogs,
                "project_logs" => InvokeParentSpanParentStructObjectType.ProjectLogs,
                _ => null,
            };
        }
    }
}
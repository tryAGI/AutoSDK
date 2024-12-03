//HintName: G.Models.ResourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queue")]
        Queue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment")]
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dashboard")]
        Dashboard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceType value)
        {
            return value switch
            {
                ResourceType.Prompt => "prompt",
                ResourceType.Project => "project",
                ResourceType.Queue => "queue",
                ResourceType.Deployment => "deployment",
                ResourceType.Experiment => "experiment",
                ResourceType.Dataset => "dataset",
                ResourceType.Dashboard => "dashboard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => ResourceType.Prompt,
                "project" => ResourceType.Project,
                "queue" => ResourceType.Queue,
                "deployment" => ResourceType.Deployment,
                "experiment" => ResourceType.Experiment,
                "dataset" => ResourceType.Dataset,
                "dashboard" => ResourceType.Dashboard,
                _ => null,
            };
        }
    }
}
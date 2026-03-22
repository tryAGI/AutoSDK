//HintName: G.Models.ResourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Dashboard,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Queue,
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
                ResourceType.Dashboard => "dashboard",
                ResourceType.Dataset => "dataset",
                ResourceType.Deployment => "deployment",
                ResourceType.Experiment => "experiment",
                ResourceType.Project => "project",
                ResourceType.Prompt => "prompt",
                ResourceType.Queue => "queue",
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
                "dashboard" => ResourceType.Dashboard,
                "dataset" => ResourceType.Dataset,
                "deployment" => ResourceType.Deployment,
                "experiment" => ResourceType.Experiment,
                "project" => ResourceType.Project,
                "prompt" => ResourceType.Prompt,
                "queue" => ResourceType.Queue,
                _ => null,
            };
        }
    }
}